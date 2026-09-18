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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void dataUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
        }

        private void dataRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRole form = new FormRole();
            form.ShowDialog();
        }

        private void dataKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategori form = new FormKategori();
            form.ShowDialog();
        }

        private void dataRuanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRuangan form = new FormRuangan();
            form.ShowDialog();
        }

        private void dataAlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlat form = new FormAlat();
            form.ShowDialog();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi form = new FormTransaksi();
            form.ShowDialog();
        }

        private void peminjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeminjam form = new FormPeminjam();
            form.ShowDialog();
        }
    }
}
