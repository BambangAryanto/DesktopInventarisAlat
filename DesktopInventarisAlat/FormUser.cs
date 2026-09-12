using System.Security.Cryptography;
using System.Text;
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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();

            loadRole();
            tampilData();
        }

        private void loadRole()
        {
            DB.crud("SELECT * FROM role");

            cmbRole.DataSource = DB.ds.Tables[0];

            cmbRole.DisplayMember = "nama_role";
            cmbRole.ValueMember = "id_role";
        }

        private void tampilData()
        {
            DB.crud(
                "SELECT " +
                "`user`.id_user, " +
                "`user`.nama_user, " +
                "`role`.nama_role " +
                "FROM `user` " +
                "INNER JOIN `role` " +
                "ON `user`.id_role = `role`.id_role"
            );

            dgvUser.DataSource = DB.ds.Tables[0];
        }

        private void bersihkan()
        {
            txtIdUser.Clear();
            txtNamaUser.Clear();
            txtPassword.Clear();

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;

            txtNamaUser.Focus();
        }

        private string GetMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes =
                    Encoding.UTF8.GetBytes(input);

                byte[] hashBytes =
                    md5.ComputeHash(inputBytes);

                StringBuilder sb =
                    new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaUser.Text))
            {
                MessageBox.Show("Nama user wajib diisi!");
                txtNamaUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password wajib diisi!");
                txtPassword.Focus();
                return;
            }

            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Role wajib dipilih!");
                cmbRole.Focus();
                return;
            }

            string passwordMD5 = GetMD5(txtPassword.Text);

            DB.crud(
                "INSERT INTO `user` " +
                "(nama_user, password, id_role) VALUES ('"
                + txtNamaUser.Text.Replace("'", "''")
                + "', '"
                + passwordMD5
                + "', "
                + cmbRole.SelectedValue
                + ")"
            );

            MessageBox.Show("Data user berhasil disimpan!");

            tampilData();
            bersihkan();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtIdUser.Text == "")
            {
                MessageBox.Show("Pilih user yang ingin diubah!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaUser.Text))
            {
                MessageBox.Show("Nama user wajib diisi!");
                txtNamaUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password wajib diisi!");
                txtPassword.Focus();
                return;
            }

            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Role wajib dipilih!");
                cmbRole.Focus();
                return;
            }

            string passwordMD5 = GetMD5(txtPassword.Text);

            DB.crud(
                "UPDATE `user` SET " +
                "nama_user = '"
                + txtNamaUser.Text.Replace("'", "''")
                + "', password = '"
                + passwordMD5
                + "', id_role = "
                + cmbRole.SelectedValue
                + " WHERE id_user = "
                + txtIdUser.Text
            );

            MessageBox.Show("Data user berhasil diubah!");

            tampilData();
            bersihkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdUser.Text == "")
            {
                MessageBox.Show("Pilih user yang ingin dihapus!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus user ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                DB.crud(
                    "DELETE FROM `user` WHERE id_user = "
                    + txtIdUser.Text
                );

                MessageBox.Show("Data user berhasil dihapus!");

                tampilData();
                bersihkan();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdUser.Text =
                    dgvUser.Rows[e.RowIndex]
                    .Cells["id_user"]
                    .Value.ToString();

                txtNamaUser.Text =
                    dgvUser.Rows[e.RowIndex]
                    .Cells["nama_user"]
                    .Value.ToString();

                cmbRole.Text =
                    dgvUser.Rows[e.RowIndex]
                    .Cells["nama_role"]
                    .Value.ToString();

                txtPassword.Clear();
            }
        }
    }
}
