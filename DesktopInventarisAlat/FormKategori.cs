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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();

        tampilData();
        }

        private void tampilData()
        {
            try
            {
                DB.crud(
                  "SELECT " +
                  "id_kategori, " +
                  "nama_kategori, " +
                  "keterangan " +
                  "FROM kategori"
                );

                if (DB.ds.Tables.Count > 0)
                {
                    dgvKategori.DataSource = DB.ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data kategori!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bersihkan()
        {
            txtIdKategori.Clear();
            txtNamaKategori.Clear();
            txtKeterangan.Clear();

            txtNamaKategori.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaKategori.Text))
            {
                MessageBox.Show(
                    "Nama kategori wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNamaKategori.Focus();
                return;
            }

            try
            {
                if (DB.koneksi.State == ConnectionState.Closed)
                {
                    DB.koneksi.Open();
                }

                string query =
                    "INSERT INTO kategori " +
                    "(nama_kategori, keterangan) " +
                    "VALUES (@nama, @keterangan)";

                DB.perintah = new MySqlCommand(query, DB.koneksi);

                DB.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtNamaKategori.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@keterangan",
                    txtKeterangan.Text
                );

                DB.perintah.ExecuteNonQuery();

                DB.koneksi.Close();

                MessageBox.Show(
                    "Data kategori berhasil disimpan!",
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
                    "Data kategori gagal disimpan!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtIdKategori.Text == "")
            {
                MessageBox.Show(
                    "Pilih kategori yang ingin diubah!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaKategori.Text))
            {
                MessageBox.Show(
                    "Nama kategori wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNamaKategori.Focus();
                return;
            }

            try
            {
                if (DB.koneksi.State == ConnectionState.Closed)
                {
                    DB.koneksi.Open();
                }

                string query =
                    "UPDATE kategori SET " +
                    "nama_kategori = @nama, " +
                    "keterangan = @keterangan " +
                    "WHERE id_kategori = @id";

                DB.perintah = new MySqlCommand(query, DB.koneksi);

                DB.perintah.Parameters.AddWithValue(
                    "@nama",
                    txtNamaKategori.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@keterangan",
                    txtKeterangan.Text
                );

                DB.perintah.Parameters.AddWithValue(
                    "@id",
                    txtIdKategori.Text
                );

                DB.perintah.ExecuteNonQuery();

                DB.koneksi.Close();

                MessageBox.Show(
                    "Data kategori berhasil diubah!",
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
                    "Data kategori gagal diubah!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdKategori.Text == "")
            {
                MessageBox.Show(
                    "Pilih kategori yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus kategori ini?",
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
                        "DELETE FROM kategori " +
                        "WHERE id_kategori = @id";

                    DB.perintah = new MySqlCommand(query, DB.koneksi);

                    DB.perintah.Parameters.AddWithValue(
                        "@id",
                        txtIdKategori.Text
                    );

                    DB.perintah.ExecuteNonQuery();

                    DB.koneksi.Close();

                    MessageBox.Show(
                        "Data kategori berhasil dihapus!",
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
                            "Kategori tidak dapat dihapus karena masih digunakan oleh data alat!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Data kategori gagal dihapus!\n\n" + ex.Message,
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
                        "Data kategori gagal dihapus!\n\n" + ex.Message,
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

        private void dgvKategori_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdKategori.Text =
                    dgvKategori.Rows[e.RowIndex]
                    .Cells["id_kategori"]
                    .Value.ToString();

                txtNamaKategori.Text =
                    dgvKategori.Rows[e.RowIndex]
                    .Cells["nama_kategori"]
                    .Value.ToString();

                txtKeterangan.Text =
                    dgvKategori.Rows[e.RowIndex]
                    .Cells["keterangan"]
                    .Value.ToString();
            }
        }
    }
}
