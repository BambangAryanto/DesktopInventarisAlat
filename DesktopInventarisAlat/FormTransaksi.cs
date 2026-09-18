using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesktopInventarisAlat
{
    public partial class FormTransaksi : Form
    {
        private string connString = "Server=localhost;Database=inventaris_desktop;Uid=root;Pwd=;";
        private DataTable dtCart = new DataTable();
        private int currentIdAlat = 0;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            InitDataTable();
            GenerateNoTransaksi();
            LoadDataPeminjam();
            dtpTanggal.Value = DateTime.Now;
            dtpTglKembali.Value = DateTime.Now.AddDays(3);
        }

        private void FormTransaksi_Activated(object sender, EventArgs e)
        {
            LoadDataPeminjam();
        }

        private void cmbPeminjam_DropDown(object sender, EventArgs e)
        {
            LoadDataPeminjam();
        }

        // 1. Inisialisasi Keranjang dengan Kolom Nama Peminjam
        private void InitDataTable()
        {
            dtCart = new DataTable();
            dtCart.Columns.Add("id_alat", typeof(int));
            dtCart.Columns.Add("kode_alat", typeof(string));
            dtCart.Columns.Add("nama_alat", typeof(string));
            dtCart.Columns.Add("nama_peminjam", typeof(string));
            dtCart.Columns.Add("jumlah", typeof(int));

            dgvCart.DataSource = dtCart;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvCart.Columns["id_alat"] != null) dgvCart.Columns["id_alat"].Visible = false;
            if (dgvCart.Columns["kode_alat"] != null) dgvCart.Columns["kode_alat"].HeaderText = "Kode Alat";
            if (dgvCart.Columns["nama_alat"] != null) dgvCart.Columns["nama_alat"].HeaderText = "Nama Alat";
            if (dgvCart.Columns["nama_peminjam"] != null) dgvCart.Columns["nama_peminjam"].HeaderText = "Nama Peminjam";
            if (dgvCart.Columns["jumlah"] != null) dgvCart.Columns["jumlah"].HeaderText = "Jumlah Pinjam";
        }

        // 2. Load Data Peminjam ke ComboBox
        public void LoadDataPeminjam()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_peminjam, nama_peminjam FROM peminjam ORDER BY nama_peminjam ASC";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dtPeminjam = new DataTable();
                    da.Fill(dtPeminjam);

                    object selectedVal = cmbPeminjam.SelectedValue;

                    cmbPeminjam.DataSource = dtPeminjam;
                    cmbPeminjam.DisplayMember = "nama_peminjam";
                    cmbPeminjam.ValueMember = "id_peminjam";

                    if (selectedVal != null)
                    {
                        cmbPeminjam.SelectedValue = selectedVal;
                    }
                    else
                    {
                        cmbPeminjam.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data peminjam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. Generate Nomor Transaksi Otomatis (TR-YYYYMMDD001)
        private void GenerateNoTransaksi()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string todayCode = "TR-" + DateTime.Now.ToString("yyyyMMdd");
                    string query = $"SELECT no_transaksi FROM peminjaman WHERE no_transaksi LIKE '{todayCode}%' ORDER BY no_transaksi DESC LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string lastNo = result.ToString();
                        int lastNum = int.Parse(lastNo.Substring(11));
                        txtNoTransaksi.Text = todayCode + (lastNum + 1).ToString("D3");
                    }
                    else
                    {
                        txtNoTransaksi.Text = todayCode + "001";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal generate no transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. Cari Data Alat & Cek Stok
        private void btnCariAlat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKodeAlat.Text))
            {
                MessageBox.Show("Masukkan kode alat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_alat, nama_alat, stok FROM alat WHERE kode_alat = @kode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kode", txtKodeAlat.Text.Trim());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentIdAlat = Convert.ToInt32(reader["id_alat"]);
                            txtNamaAlat.Text = reader["nama_alat"].ToString();
                            txtStok.Text = reader["stok"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Alat dengan kode tersebut tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            currentIdAlat = 0;
                            txtNamaAlat.Clear();
                            txtStok.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error pencarian alat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 5. Tambah Item ke Keranjang
        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            if (cmbPeminjam.SelectedValue == null)
            {
                MessageBox.Show("Pilih peminjam terlebih dahulu sebelum menambah item!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentIdAlat == 0 || string.IsNullOrWhiteSpace(txtKodeAlat.Text) || string.IsNullOrWhiteSpace(txtNamaAlat.Text))
            {
                MessageBox.Show("Cari dan pilih alat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStok.Text, out int stokAda))
            {
                MessageBox.Show("Data stok tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qtyInput = (int)nudJumlah.Value;

            if (qtyInput <= 0)
            {
                MessageBox.Show("Jumlah pinjam harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (qtyInput > stokAda)
            {
                MessageBox.Show("Jumlah pinjam melebihi stok yang tersedia!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaPeminjam = cmbPeminjam.Text;

            foreach (DataRow row in dtCart.Rows)
            {
                if (row["kode_alat"].ToString() == txtKodeAlat.Text.Trim())
                {
                    int currentQty = Convert.ToInt32(row["jumlah"]);
                    if (currentQty + qtyInput > stokAda)
                    {
                        MessageBox.Show("Total item di keranjang melebihi stok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    row["jumlah"] = currentQty + qtyInput;
                    row["nama_peminjam"] = namaPeminjam;
                    ClearInputItem();
                    return;
                }
            }

            dtCart.Rows.Add(currentIdAlat, txtKodeAlat.Text.Trim(), txtNamaAlat.Text.Trim(), namaPeminjam, qtyInput);
            ClearInputItem();
        }

        private void ClearInputItem()
        {
            currentIdAlat = 0;
            txtKodeAlat.Clear();
            txtNamaAlat.Clear();
            txtStok.Clear();
            nudJumlah.Value = 1;
        }

        // 6. Simpan Transaksi Lengkap ke Database
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbPeminjam.SelectedValue == null)
            {
                MessageBox.Show("Pilih nama peminjam terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtCart.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang peminjaman masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // A. Insert Header Peminjaman
                    string qHeader = @"INSERT INTO peminjaman (no_transaksi, id_peminjam, tgl_pinjam, tgl_rencana_kembali, status, keterangan) 
                                       VALUES (@no, @idPeminjam, @tglPinjam, @tglKembali, 'Dipinjam', @ket)";

                    MySqlCommand cmdHeader = new MySqlCommand(qHeader, conn, transaction);
                    cmdHeader.Parameters.AddWithValue("@no", txtNoTransaksi.Text);
                    cmdHeader.Parameters.AddWithValue("@idPeminjam", cmbPeminjam.SelectedValue);
                    cmdHeader.Parameters.AddWithValue("@tglPinjam", dtpTanggal.Value);
                    cmdHeader.Parameters.AddWithValue("@tglKembali", dtpTglKembali.Value);
                    cmdHeader.Parameters.AddWithValue("@ket", txtKeterangan.Text.Trim());
                    cmdHeader.ExecuteNonQuery();

                    long idPeminjaman = cmdHeader.LastInsertedId;

                    // B. Insert Detail & Potong Stok Alat
                    foreach (DataRow row in dtCart.Rows)
                    {
                        int idAlat = Convert.ToInt32(row["id_alat"]);
                        string kodeAlat = row["kode_alat"].ToString();
                        int qty = Convert.ToInt32(row["jumlah"]);

                        string qDetail = @"INSERT INTO detail_peminjaman (no_transaksi, kode_alat, id_peminjaman, id_alat, jumlah) 
                                           VALUES (@no, @kode, @idPeminjaman, @idAlat, @qty)";
                        MySqlCommand cmdDetail = new MySqlCommand(qDetail, conn, transaction);
                        cmdDetail.Parameters.AddWithValue("@no", txtNoTransaksi.Text);
                        cmdDetail.Parameters.AddWithValue("@kode", kodeAlat);
                        cmdDetail.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                        cmdDetail.Parameters.AddWithValue("@idAlat", idAlat);
                        cmdDetail.Parameters.AddWithValue("@qty", qty);
                        cmdDetail.ExecuteNonQuery();

                        string qUpdateStok = "UPDATE alat SET stok = stok - @qty WHERE id_alat = @idAlat";
                        MySqlCommand cmdStok = new MySqlCommand(qUpdateStok, conn, transaction);
                        cmdStok.Parameters.AddWithValue("@qty", qty);
                        cmdStok.Parameters.AddWithValue("@idAlat", idAlat);
                        cmdStok.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Transaksi peminjaman berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Panggil reset form tanpa menghapus keranjang
                    ResetForm(false);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Parameter clearCart menentukan apakah keranjang ikut dibersihkan atau tidak
        private void ResetForm(bool clearCart = true)
        {
            cmbPeminjam.SelectedIndex = -1;
            txtKeterangan.Clear();

            if (clearCart)
            {
                dtCart.Clear();
            }

            ClearInputItem();
            GenerateNoTransaksi();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ResetForm(true); // Tombol batal tetap membersihkan seluruh form dan keranjang
        }
    }
}