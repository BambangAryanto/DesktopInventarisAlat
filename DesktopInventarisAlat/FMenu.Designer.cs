
namespace DesktopInventarisAlat
{
    partial class FMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRuanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataUserToolStripMenuItem,
            this.dataRoleToolStripMenuItem,
            this.dataKategoriToolStripMenuItem,
            this.dataRuanganToolStripMenuItem,
            this.dataAlatToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.peminjamToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // dataUserToolStripMenuItem
            // 
            this.dataUserToolStripMenuItem.Name = "dataUserToolStripMenuItem";
            this.dataUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataUserToolStripMenuItem.Text = "Data User";
            this.dataUserToolStripMenuItem.Click += new System.EventHandler(this.dataUserToolStripMenuItem_Click);
            // 
            // dataRoleToolStripMenuItem
            // 
            this.dataRoleToolStripMenuItem.Name = "dataRoleToolStripMenuItem";
            this.dataRoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataRoleToolStripMenuItem.Text = "Data Role";
            this.dataRoleToolStripMenuItem.Click += new System.EventHandler(this.dataRoleToolStripMenuItem_Click);
            // 
            // dataKategoriToolStripMenuItem
            // 
            this.dataKategoriToolStripMenuItem.Name = "dataKategoriToolStripMenuItem";
            this.dataKategoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataKategoriToolStripMenuItem.Text = "Data Kategori";
            this.dataKategoriToolStripMenuItem.Click += new System.EventHandler(this.dataKategoriToolStripMenuItem_Click);
            // 
            // dataRuanganToolStripMenuItem
            // 
            this.dataRuanganToolStripMenuItem.Name = "dataRuanganToolStripMenuItem";
            this.dataRuanganToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataRuanganToolStripMenuItem.Text = "Data Ruangan";
            this.dataRuanganToolStripMenuItem.Click += new System.EventHandler(this.dataRuanganToolStripMenuItem_Click);
            // 
            // dataAlatToolStripMenuItem
            // 
            this.dataAlatToolStripMenuItem.Name = "dataAlatToolStripMenuItem";
            this.dataAlatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataAlatToolStripMenuItem.Text = "Data Alat";
            this.dataAlatToolStripMenuItem.Click += new System.EventHandler(this.dataAlatToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // peminjamToolStripMenuItem
            // 
            this.peminjamToolStripMenuItem.Name = "peminjamToolStripMenuItem";
            this.peminjamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peminjamToolStripMenuItem.Text = "Peminjam";
            this.peminjamToolStripMenuItem.Click += new System.EventHandler(this.peminjamToolStripMenuItem_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRuanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamToolStripMenuItem;
    }
}