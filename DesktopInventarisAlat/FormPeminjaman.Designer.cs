namespace DesktopInventarisAlat
{
    partial class FormPeminjam
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNoTlp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNoTlp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvPeminjam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(24, 18);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(217, 24);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Kelola Data Peminjam";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(25, 65);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(84, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Peminjam:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(120, 62);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(260, 20);
            this.txtNama.TabIndex = 2;
            // 
            // lblNoTlp
            // 
            this.lblNoTlp.AutoSize = true;
            this.lblNoTlp.Location = new System.Drawing.Point(25, 95);
            this.lblNoTlp.Name = "lblNoTlp";
            this.lblNoTlp.Size = new System.Drawing.Size(69, 13);
            this.lblNoTlp.TabIndex = 3;
            this.lblNoTlp.Text = "No. Telepon:";
            // 
            // txtNoTlp
            // 
            this.txtNoTlp.Location = new System.Drawing.Point(120, 92);
            this.txtNoTlp.Name = "txtNoTlp";
            this.txtNoTlp.Size = new System.Drawing.Size(260, 20);
            this.txtNoTlp.TabIndex = 4;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(25, 125);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(42, 13);
            this.lblAlamat.TabIndex = 5;
            this.lblAlamat.Text = "Alamat:";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(120, 122);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(260, 60);
            this.txtAlamat.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(120, 192);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(210, 192);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 30);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(300, 192);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 30);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(410, 25);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(56, 13);
            this.lblCari.TabIndex = 10;
            this.lblCari.Text = "Cari Data:";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(472, 22);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(220, 20);
            this.txtCari.TabIndex = 11;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dgvPeminjam
            // 
            this.dgvPeminjam.AllowUserToAddRows = false;
            this.dgvPeminjam.AllowUserToDeleteRows = false;
            this.dgvPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjam.Location = new System.Drawing.Point(413, 55);
            this.dgvPeminjam.MultiSelect = false;
            this.dgvPeminjam.Name = "dgvPeminjam";
            this.dgvPeminjam.ReadOnly = true;
            this.dgvPeminjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeminjam.Size = new System.Drawing.Size(350, 167);
            this.dgvPeminjam.TabIndex = 12;
            this.dgvPeminjam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjam_CellClick);
            // 
            // FormPeminjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 241);
            this.Controls.Add(this.dgvPeminjam);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtNoTlp);
            this.Controls.Add(this.lblNoTlp);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormPeminjam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Data Peminjam";
            this.Load += new System.EventHandler(this.FormPeminjam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNoTlp;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNoTlp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvPeminjam;
    }
}