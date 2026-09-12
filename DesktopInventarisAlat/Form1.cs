using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DesktopInventarisAlat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string GetMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwordMD5 = GetMD5(TXTPASS.Text);
            DB.crud($"SELECT * FROM user WHERE nama_user = '{TXTUSER.Text}' AND password = '{passwordMD5}';");
            int cekjumlahbaris = DB.ds.Tables[0].Rows.Count;
            if (cekjumlahbaris == 1)
            {
                FMenu b = new FMenu();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }
    }
}
