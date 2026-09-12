using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopInventarisAlat
{
    public partial class FormRuangan : Form
    {
        public FormRuangan()
        {
            InitializeComponent();

            tampilData();
        }

        private void tampilData()
        {
            DB.crud(
                "SELECT " +
                "id_ruang, " +
                "nama_ruang, " +
                "lokasi, " +
                "keterangan " +
                "FROM ruangan"
            );

            dgvRuangan.DataSource = DB.ds.Tables[0];
        }

        private void bersihkan()
        {
            txtIdRuangan.Clear();
            txtNamaRuangan.Clear();
            txtLokasi.Clear();
            txtKeterangan.Clear();

            txtNamaRuangan.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaRuangan.Text))
            {
                MessageBox.Show("Nama ruangan wajib diisi!");
                txtNamaRuangan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show("Lokasi ruangan wajib diisi!");
                txtLokasi.Focus();
                return;
            }

            DB.crud(
                "INSERT INTO ruangan " +
                "(nama_ruang, lokasi, keterangan) VALUES ('"
                + txtNamaRuangan.Text.Replace("'", "''")
                + "', '"
                + txtLokasi.Text.Replace("'", "''")
                + "', '"
                + txtKeterangan.Text.Replace("'", "''")
                + "')"
            );

            MessageBox.Show("Data ruangan berhasil disimpan!");

            tampilData();
            bersihkan();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtIdRuangan.Text == "")
            {
                MessageBox.Show("Pilih ruangan yang ingin diubah!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaRuangan.Text))
            {
                MessageBox.Show("Nama ruangan wajib diisi!");
                txtNamaRuangan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show("Lokasi ruangan wajib diisi!");
                txtLokasi.Focus();
                return;
            }

            DB.crud(
                "UPDATE ruangan SET " +
                "nama_ruang = '"
                + txtNamaRuangan.Text.Replace("'", "''")
                + "', lokasi = '"
                + txtLokasi.Text.Replace("'", "''")
                + "', keterangan = '"
                + txtKeterangan.Text.Replace("'", "''")
                + "' WHERE id_ruang = "
                + txtIdRuangan.Text
            );

            MessageBox.Show("Data ruangan berhasil diubah!");

            tampilData();
            bersihkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdRuangan.Text == "")
            {
                MessageBox.Show("Pilih ruangan yang ingin dihapus!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus ruangan ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                try
                {
                    DB.crud(
                        "DELETE FROM ruangan WHERE id_ruang = "
                        + txtIdRuangan.Text
                    );

                    MessageBox.Show("Data ruangan berhasil dihapus!");

                    tampilData();
                    bersihkan();
                }
                catch
                {
                    MessageBox.Show(
                        "Ruangan tidak dapat dihapus karena masih digunakan oleh data alat!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void dgvRuangan_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdRuangan.Text =
                    dgvRuangan.Rows[e.RowIndex]
                    .Cells["id_ruang"] // Ganti id_ruangan menjadi id_ruang
                    .Value.ToString();

                txtNamaRuangan.Text =
                    dgvRuangan.Rows[e.RowIndex]
                    .Cells["nama_ruang"]
                    .Value.ToString();

                txtLokasi.Text =
                    dgvRuangan.Rows[e.RowIndex]
                    .Cells["lokasi"]
                    .Value.ToString();

                txtKeterangan.Text =
                    dgvRuangan.Rows[e.RowIndex]
                    .Cells["keterangan"]
                    .Value.ToString();
            }
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            DB.crud(
                "UPDATE ruangan SET " +
                "nama_ruang = '"
                + txtNamaRuangan.Text.Replace("'", "''")
                + "', lokasi = '"
                + txtLokasi.Text.Replace("'", "''")
                + "', keterangan = '"
                + txtKeterangan.Text.Replace("'", "''")
                + "' WHERE id_ruang = " // Ganti id_ruangan menjadi id_ruang
                + txtIdRuangan.Text
);
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            DB.crud(
                "DELETE FROM ruangan WHERE id_ruang = " // Ganti id_ruangan menjadi id_ruang
                + txtIdRuangan.Text
            );
        }
    }
}