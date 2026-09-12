
namespace DesktopInventarisAlat
{
    partial class FormAlat
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
            this.txtIdAlat = new System.Windows.Forms.TextBox();
            this.txtKodeAlat = new System.Windows.Forms.TextBox();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbRuangan = new System.Windows.Forms.ComboBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtTipe = new System.Windows.Forms.TextBox();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.cmbKondisi = new System.Windows.Forms.ComboBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvAlat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdAlat
            // 
            this.txtIdAlat.Location = new System.Drawing.Point(158, 7);
            this.txtIdAlat.Name = "txtIdAlat";
            this.txtIdAlat.ReadOnly = true;
            this.txtIdAlat.Size = new System.Drawing.Size(161, 20);
            this.txtIdAlat.TabIndex = 0;
            // 
            // txtKodeAlat
            // 
            this.txtKodeAlat.Location = new System.Drawing.Point(158, 33);
            this.txtKodeAlat.Name = "txtKodeAlat";
            this.txtKodeAlat.Size = new System.Drawing.Size(161, 20);
            this.txtKodeAlat.TabIndex = 1;
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(158, 59);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.Size = new System.Drawing.Size(161, 20);
            this.txtNamaAlat.TabIndex = 2;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(158, 85);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(161, 21);
            this.cmbKategori.TabIndex = 3;
            // 
            // cmbRuangan
            // 
            this.cmbRuangan.FormattingEnabled = true;
            this.cmbRuangan.Location = new System.Drawing.Point(158, 112);
            this.cmbRuangan.Name = "cmbRuangan";
            this.cmbRuangan.Size = new System.Drawing.Size(161, 21);
            this.cmbRuangan.TabIndex = 4;
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(158, 191);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(161, 20);
            this.txtTahun.TabIndex = 7;
            // 
            // txtTipe
            // 
            this.txtTipe.Location = new System.Drawing.Point(158, 165);
            this.txtTipe.Name = "txtTipe";
            this.txtTipe.Size = new System.Drawing.Size(161, 20);
            this.txtTipe.TabIndex = 6;
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(158, 139);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(161, 20);
            this.txtMerk.TabIndex = 5;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(158, 217);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(161, 20);
            this.txtJumlah.TabIndex = 8;
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Location = new System.Drawing.Point(158, 243);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.Size = new System.Drawing.Size(161, 21);
            this.cmbKondisi.TabIndex = 9;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(158, 270);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(161, 20);
            this.txtKeterangan.TabIndex = 10;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(249, 305);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(168, 305);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(87, 305);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 13;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 305);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dgvAlat
            // 
            this.dgvAlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlat.Location = new System.Drawing.Point(3, 334);
            this.dgvAlat.Name = "dgvAlat";
            this.dgvAlat.Size = new System.Drawing.Size(795, 114);
            this.dgvAlat.TabIndex = 16;
            this.dgvAlat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "nama alat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ruang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "tahun pembuatan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "tipe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "merk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "keterangan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "kondisi";
            // 
            // FormAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlat);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.cmbKondisi);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.txtTipe);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.cmbRuangan);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtNamaAlat);
            this.Controls.Add(this.txtKodeAlat);
            this.Controls.Add(this.txtIdAlat);
            this.Name = "FormAlat";
            this.Text = "FormAlat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdAlat;
        private System.Windows.Forms.TextBox txtKodeAlat;
        private System.Windows.Forms.TextBox txtNamaAlat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbRuangan;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.TextBox txtTipe;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.ComboBox cmbKondisi;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvAlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}