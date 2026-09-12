using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesktopInventarisAlat
{
    public partial class FormAlat : Form
    {
        public FormAlat()
        {
            InitializeComponent();

        loadKategori();
            loadRuangan();
            loadKondisi();
            tampilData();
        }

        private void loadKategori()
        {
            DB.crud("SELECT * FROM kategori");

            cmbKategori.DataSource = DB.ds.Tables[0];

            cmbKategori.DisplayMember = "nama_kategori";
            cmbKategori.ValueMember = "id_kategori";
        }

        private void loadRuangan()
        {
            DB.crud("SELECT * FROM ruangan");

            cmbRuangan.DataSource = DB.ds.Tables[0];

            cmbRuangan.DisplayMember = "nama_ruang";
            cmbRuangan.ValueMember = "id_ruang";
        }

        private void loadKondisi()
        {
            cmbKondisi.Items.Clear();

            cmbKondisi.Items.Add("Baik");
            cmbKondisi.Items.Add("Rusak Ringan");
            cmbKondisi.Items.Add("Rusak Berat");

            if (cmbKondisi.Items.Count > 0)
                cmbKondisi.SelectedIndex = 0;
        }

        private void tampilData()
        {
            try
            {
                DB.crud(
                    "SELECT " +
                    "alat.id_alat, " +
                    "alat.kode_alat, " +
                    "alat.nama_alat, " +
                    "kategori.nama_kategori, " +
                    "ruangan.nama_ruang, " +
                    "alat.merk, " +
                    "alat.tipe, " +
                    "alat.tahun_pembuatan, " +
                    "alat.jumlah, " +
                    "alat.kondisi, " +
                    "alat.keterangan " +
                    "FROM alat " +
                    "INNER JOIN kategori " +
                    "ON alat.id_kategori = kategori.id_kategori " +
                    "INNER JOIN ruangan " +
                    "ON alat.id_ruang = ruangan.id_ruang"
                );

                if (DB.ds.Tables.Count > 0)
                {
                    dgvAlat.DataSource = DB.ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data alat!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bersihkan()
        {
            txtIdAlat.Clear();
            txtKodeAlat.Clear();
            txtNamaAlat.Clear();
            txtMerk.Clear();
            txtTipe.Clear();
            txtTahun.Clear();
            txtJumlah.Clear();
            txtKeterangan.Clear();

            if (cmbKategori.Items.Count > 0)
                cmbKategori.SelectedIndex = 0;

            if (cmbRuangan.Items.Count > 0)
                cmbRuangan.SelectedIndex = 0;

            if (cmbKondisi.Items.Count > 0)
                cmbKondisi.SelectedIndex = 0;

            txtKodeAlat.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKodeAlat.Text))
            {
                MessageBox.Show("Kode alat wajib diisi!");
                txtKodeAlat.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaAlat.Text))
            {
                MessageBox.Show("Nama alat wajib diisi!");
                txtNamaAlat.Focus();
                return;
            }

            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategori wajib dipilih!");
                cmbKategori.Focus();
                return;
            }

            if (cmbRuangan.SelectedValue == null)
            {
                MessageBox.Show("Ruangan wajib dipilih!");
                cmbRuangan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Jumlah alat wajib diisi!");
                txtJumlah.Focus();
                return;
            }

            int jumlah;

            if (!int.TryParse(txtJumlah.Text, out jumlah))
            {
                MessageBox.Show("Jumlah alat harus berupa angka!");
                txtJumlah.Focus();
                return;
            }

            if (jumlah < 0)
            {
                MessageBox.Show("Jumlah alat tidak boleh kurang dari 0!");
                txtJumlah.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTahun.Text))
            {
                MessageBox.Show("Tahun pembuatan wajib diisi!");
                txtTahun.Focus();
                return;
            }

            int tahun;

            if (!int.TryParse(txtTahun.Text, out tahun))
            {
                MessageBox.Show("Tahun pembuatan harus berupa angka!");
                txtTahun.Focus();
                return;
            }

            if (cmbKondisi.SelectedItem == null)
            {
                MessageBox.Show("Kondisi alat wajib dipilih!");
                cmbKondisi.Focus();
                return;
            }

            try
            {
                if (DB.koneksi.State == ConnectionState.Closed)
                {
                    DB.koneksi.Open();
                }

                string query =
                    "INSERT INTO alat " +
                    "(kode_alat, nama_alat, id_kategori, id_ruang, merk, tipe, tahun_pembuatan, jumlah, kondisi, keterangan) " +
                    "VALUES (@kode, @nama, @kategori, @ruang, @merk, @tipe, @tahun, @jumlah, @kondisi, @keterangan)";

                DB.perintah = new MySqlCommand(query, DB.koneksi);

                DB.perintah.Parameters.AddWithValue(
                    "@kode",
                    txtKodeAlat.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtNamaAlat.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@kategori",
                    cmbKategori.SelectedValue
                );

                DB.perintah.Parameters.AddWithValue(
                    "@ruang",
                    cmbRuangan.SelectedValue
                );

                DB.perintah.Parameters.AddWithValue(
                    "@merk",
                    txtMerk.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@tipe",
                    txtTipe.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@tahun",
                    tahun
                );

                DB.perintah.Parameters.AddWithValue(
                    "@jumlah",
                    jumlah
                );

                DB.perintah.Parameters.AddWithValue(
                    "@kondisi",
                    cmbKondisi.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@keterangan",
                    txtKeterangan.Text
                );

                DB.perintah.ExecuteNonQuery();

                DB.koneksi.Close();

                MessageBox.Show(
                    "Data alat berhasil disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                tampilData();
                bersihkan();
            }
            catch (Exception ex)
            {
                if (DB.koneksi.State == ConnectionState.Open)
                {
                    DB.koneksi.Close();
                }

                MessageBox.Show(
                    "Data alat gagal disimpan!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtIdAlat.Text == "")
            {
                MessageBox.Show("Pilih alat yang ingin diubah!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKodeAlat.Text))
            {
                MessageBox.Show("Kode alat wajib diisi!");
                txtKodeAlat.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaAlat.Text))
            {
                MessageBox.Show("Nama alat wajib diisi!");
                txtNamaAlat.Focus();
                return;
            }

            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategori wajib dipilih!");
                cmbKategori.Focus();
                return;
            }

            if (cmbRuangan.SelectedValue == null)
            {
                MessageBox.Show("Ruangan wajib dipilih!");
                cmbRuangan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Jumlah alat wajib diisi!");
                txtJumlah.Focus();
                return;
            }

            int jumlah;

            if (!int.TryParse(txtJumlah.Text, out jumlah))
            {
                MessageBox.Show("Jumlah alat harus berupa angka!");
                txtJumlah.Focus();
                return;
            }

            if (jumlah < 0)
            {
                MessageBox.Show("Jumlah alat tidak boleh kurang dari 0!");
                txtJumlah.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTahun.Text))
            {
                MessageBox.Show("Tahun pembuatan wajib diisi!");
                txtTahun.Focus();
                return;
            }

            int tahun;

            if (!int.TryParse(txtTahun.Text, out tahun))
            {
                MessageBox.Show("Tahun pembuatan harus berupa angka!");
                txtTahun.Focus();
                return;
            }

            if (cmbKondisi.SelectedItem == null)
            {
                MessageBox.Show("Kondisi alat wajib dipilih!");
                cmbKondisi.Focus();
                return;
            }

            try
            {
                if (DB.koneksi.State == ConnectionState.Closed)
                {
                    DB.koneksi.Open();
                }

                string query =
                    "UPDATE alat SET " +
                    "kode_alat = @kode, " +
                    "nama_alat = @nama, " +
                    "id_kategori = @kategori, " +
                    "id_ruang = @ruang, " +
                    "merk = @merk, " +
                    "tipe = @tipe, " +
                    "tahun_pembuatan = @tahun, " +
                    "jumlah = @jumlah, " +
                    "kondisi = @kondisi, " +
                    "keterangan = @keterangan " +
                    "WHERE id_alat = @id";

                DB.perintah = new MySqlCommand(query, DB.koneksi);

                DB.perintah.Parameters.AddWithValue(
                    "@kode",
                    txtKodeAlat.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtNamaAlat.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@kategori",
                    cmbKategori.SelectedValue
                );

                DB.perintah.Parameters.AddWithValue(
                    "@ruang",
                    cmbRuangan.SelectedValue
                );

                DB.perintah.Parameters.AddWithValue(
                    "@merk",
                    txtMerk.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@tipe",
                    txtTipe.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@tahun",
                    tahun
                );

                DB.perintah.Parameters.AddWithValue(
                    "@jumlah",
                    jumlah
                );

                DB.perintah.Parameters.AddWithValue(
                    "@kondisi",
                    cmbKondisi.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@keterangan",
                    txtKeterangan.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@id",
                    txtIdAlat.Text
                );

                DB.perintah.ExecuteNonQuery();

                DB.koneksi.Close();

                MessageBox.Show(
                    "Data alat berhasil diubah!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                tampilData();
                bersihkan();
            }
            catch (Exception ex)
            {
                if (DB.koneksi.State == ConnectionState.Open)
                {
                    DB.koneksi.Close();
                }

                MessageBox.Show(
                    "Data alat gagal diubah!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdAlat.Text == "")
            {
                MessageBox.Show("Pilih alat yang ingin dihapus!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus alat ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                try
                {
                    if (DB.koneksi.State == ConnectionState.Closed)
                    {
                        DB.koneksi.Open();
                    }

                    string query =
                        "DELETE FROM alat " +
                        "WHERE id_alat = @id";

                    DB.perintah = new MySqlCommand(query, DB.koneksi);

                    DB.perintah.Parameters.AddWithValue(
                        "@id",
                        txtIdAlat.Text
                    );

                    DB.perintah.ExecuteNonQuery();

                    DB.koneksi.Close();

                    MessageBox.Show(
                        "Data alat berhasil dihapus!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    tampilData();
                    bersihkan();
                }
                catch (MySqlException ex)
                {
                    if (DB.koneksi.State == ConnectionState.Open)
                    {
                        DB.koneksi.Close();
                    }

                    if (ex.Number == 1451)
                    {
                        MessageBox.Show(
                            "Data alat tidak dapat dihapus karena sudah digunakan dalam transaksi!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Data alat gagal dihapus!\n\n" + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                catch (Exception ex)
                {
                    if (DB.koneksi.State == ConnectionState.Open)
                    {
                        DB.koneksi.Close();
                    }

                    MessageBox.Show(
                        "Data alat gagal dihapus!\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void dgvAlat_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdAlat.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["id_alat"]
                    .Value.ToString();

                txtKodeAlat.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["kode_alat"]
                    .Value.ToString();

                txtNamaAlat.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["nama_alat"]
                    .Value.ToString();

                cmbKategori.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["nama_kategori"]
                    .Value.ToString();

                cmbRuangan.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["nama_ruang"]
                    .Value.ToString();

                txtMerk.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["merk"]
                    .Value.ToString();

                txtTipe.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["tipe"]
                    .Value.ToString();

                txtTahun.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["tahun_pembuatan"]
                    .Value.ToString();

                txtJumlah.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["jumlah"]
                    .Value.ToString();

                cmbKondisi.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["kondisi"]
                    .Value.ToString();

                txtKeterangan.Text =
                    dgvAlat.Rows[e.RowIndex]
                    .Cells["keterangan"]
                    .Value.ToString();
            }
        }
    }
}
