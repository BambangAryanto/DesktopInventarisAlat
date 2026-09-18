using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesktopInventarisAlat
{
    public partial class FormPeminjam : Form
    {
        private string connString = "Server=localhost;Database=inventaris_desktop;Uid=root;Pwd=;";
        private int selectedIdPeminjam = 0;

        public FormPeminjam()
        {
            InitializeComponent();
        }

        private void FormPeminjam_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearInput();
        }

        private void LoadData(string keyword = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_peminjam, nama_peminjam, no_tlp, alamat FROM peminjam";
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        query += " WHERE nama_peminjam LIKE @key OR no_tlp LIKE @key OR alamat LIKE @key";
                    }
                    query += " ORDER BY id_peminjam DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        cmd.Parameters.AddWithValue("@key", "%" + keyword.Trim() + "%");
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPeminjam.DataSource = dt;
                    dgvPeminjam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvPeminjam.Columns["id_peminjam"] != null)
                        dgvPeminjam.Columns["id_peminjam"].HeaderText = "ID Peminjam";
                    if (dgvPeminjam.Columns["nama_peminjam"] != null)
                        dgvPeminjam.Columns["nama_peminjam"].HeaderText = "Nama Peminjam";
                    if (dgvPeminjam.Columns["no_tlp"] != null)
                        dgvPeminjam.Columns["no_tlp"].HeaderText = "No. Telepon";
                    if (dgvPeminjam.Columns["alamat"] != null)
                        dgvPeminjam.Columns["alamat"].HeaderText = "Alamat";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data peminjam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama peminjam wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd;

                    if (selectedIdPeminjam == 0)
                    {
                        string query = "INSERT INTO peminjam (nama_peminjam, no_tlp, alamat) VALUES (@nama, @tlp, @alamat)";
                        cmd = new MySqlCommand(query, conn);
                    }
                    else
                    {
                        string query = "UPDATE peminjam SET nama_peminjam=@nama, no_tlp=@tlp, alamat=@alamat WHERE id_peminjam=@id";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedIdPeminjam);
                    }

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                    cmd.Parameters.AddWithValue("@tlp", txtNoTlp.Text.Trim());
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data peminjam berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdPeminjam == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus data peminjam ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM peminjam WHERE id_peminjam=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedIdPeminjam);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data peminjam berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearInput();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data (Peminjam terikat transaksi): " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvPeminjam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPeminjam.Rows[e.RowIndex];
                selectedIdPeminjam = Convert.ToInt32(row.Cells["id_peminjam"].Value);
                txtNama.Text = row.Cells["nama_peminjam"].Value.ToString();
                txtNoTlp.Text = row.Cells["no_tlp"].Value != null ? row.Cells["no_tlp"].Value.ToString() : "";
                txtAlamat.Text = row.Cells["alamat"].Value != null ? row.Cells["alamat"].Value.ToString() : "";

                btnSimpan.Text = "Ubah";
                btnHapus.Enabled = true;
            }
        }

        private void ClearInput()
        {
            selectedIdPeminjam = 0;
            txtNama.Clear();
            txtNoTlp.Clear();
            txtAlamat.Clear();
            btnSimpan.Text = "Simpan";
            btnHapus.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtCari.Text);
        }

        private void FormPeminjam_Load_1(object sender, EventArgs e)
        {

        }
    }
}