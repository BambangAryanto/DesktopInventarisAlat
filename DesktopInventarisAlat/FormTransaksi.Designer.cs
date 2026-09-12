
namespace DesktopInventarisAlat
{
    partial class FormTransaksi
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
            this.txtNoTransaksi = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.dtpTglKembali = new System.Windows.Forms.DateTimePicker();
            this.txtKodeAlat = new System.Windows.Forms.TextBox();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.btnCariAlat = new System.Windows.Forms.Button();
            this.btnTambahItem = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cmbPeminjam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoTransaksi
            // 
            this.txtNoTransaksi.Location = new System.Drawing.Point(125, 42);
            this.txtNoTransaksi.Name = "txtNoTransaksi";
            this.txtNoTransaksi.ReadOnly = true;
            this.txtNoTransaksi.Size = new System.Drawing.Size(136, 20);
            this.txtNoTransaksi.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(480, 42);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggal.TabIndex = 4;
            // 
            // dtpTglKembali
            // 
            this.dtpTglKembali.Location = new System.Drawing.Point(480, 94);
            this.dtpTglKembali.Name = "dtpTglKembali";
            this.dtpTglKembali.Size = new System.Drawing.Size(200, 20);
            this.dtpTglKembali.TabIndex = 5;
            // 
            // txtKodeAlat
            // 
            this.txtKodeAlat.Location = new System.Drawing.Point(125, 172);
            this.txtKodeAlat.Name = "txtKodeAlat";
            this.txtKodeAlat.Size = new System.Drawing.Size(100, 20);
            this.txtKodeAlat.TabIndex = 6;
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(125, 198);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.ReadOnly = true;
            this.txtNamaAlat.Size = new System.Drawing.Size(100, 20);
            this.txtNamaAlat.TabIndex = 7;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(480, 172);
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 8;
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(480, 198);
            this.nudJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(120, 20);
            this.nudJumlah.TabIndex = 9;
            // 
            // btnCariAlat
            // 
            this.btnCariAlat.Location = new System.Drawing.Point(302, 169);
            this.btnCariAlat.Name = "btnCariAlat";
            this.btnCariAlat.Size = new System.Drawing.Size(75, 23);
            this.btnCariAlat.TabIndex = 10;
            this.btnCariAlat.Text = "Cari";
            this.btnCariAlat.UseVisualStyleBackColor = true;
            // 
            // btnTambahItem
            // 
            this.btnTambahItem.Location = new System.Drawing.Point(220, 243);
            this.btnTambahItem.Name = "btnTambahItem";
            this.btnTambahItem.Size = new System.Drawing.Size(75, 23);
            this.btnTambahItem.TabIndex = 11;
            this.btnTambahItem.Text = "Tambah";
            this.btnTambahItem.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(1, 299);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(801, 113);
            this.dgvCart.TabIndex = 12;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(125, 418);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(100, 20);
            this.txtKeterangan.TabIndex = 13;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(494, 418);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(605, 418);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // cmbPeminjam
            // 
            this.cmbPeminjam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeminjam.FormattingEnabled = true;
            this.cmbPeminjam.Location = new System.Drawing.Point(125, 69);
            this.cmbPeminjam.Name = "cmbPeminjam";
            this.cmbPeminjam.Size = new System.Drawing.Size(121, 21);
            this.cmbPeminjam.TabIndex = 16;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPeminjam);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnTambahItem);
            this.Controls.Add(this.btnCariAlat);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtNamaAlat);
            this.Controls.Add(this.txtKodeAlat);
            this.Controls.Add(this.dtpTglKembali);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtNoTransaksi);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoTransaksi;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.TextBox txtKodeAlat;
        private System.Windows.Forms.TextBox txtNamaAlat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Button btnCariAlat;
        private System.Windows.Forms.Button btnTambahItem;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox cmbPeminjam;
    }
}