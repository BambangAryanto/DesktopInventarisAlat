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
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
            tampilData();
        }

        private void tampilData()
        {
            DB.crud("SELECT * FROM role");

            dgvRole.DataSource = DB.ds.Tables[0];
        }

        private void bersihkan()
        {
            txtIdRole.Clear();
            txtNamaRole.Clear();

            txtNamaRole.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaRole.Text))
            {
                MessageBox.Show("Nama role wajib diisi!");
                txtNamaRole.Focus();
                return;
            }

            DB.crud(
                "INSERT INTO role (nama_role) VALUES ('"
                + txtNamaRole.Text.Replace("'", "''")
                + "')"
            );

            MessageBox.Show("Data role berhasil disimpan!");

            tampilData();
            bersihkan();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtIdRole.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin diubah!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaRole.Text))
            {
                MessageBox.Show("Nama role wajib diisi!");
                txtNamaRole.Focus();
                return;
            }

            DB.crud(
                "UPDATE role SET nama_role = '"
                + txtNamaRole.Text.Replace("'", "''")
                + "' WHERE id_role = "
                + txtIdRole.Text
            );

            MessageBox.Show("Data role berhasil diubah!");

            tampilData();
            bersihkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdRole.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                DB.crud(
                    "DELETE FROM role WHERE id_role = "
                    + txtIdRole.Text
                );

                MessageBox.Show("Data role berhasil dihapus!");

                tampilData();
                bersihkan();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdRole.Text =
                    dgvRole.Rows[e.RowIndex]
                    .Cells["id_role"].Value.ToString();

                txtNamaRole.Text =
                    dgvRole.Rows[e.RowIndex]
                    .Cells["nama_role"].Value.ToString();
            }
        }
    }
}
