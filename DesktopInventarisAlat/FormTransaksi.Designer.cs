namespace DesktopInventarisAlat
{
    partial class FormTransaksi
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
            this.lblNoTransaksi = new System.Windows.Forms.Label();
            this.txtNoTransaksi = new System.Windows.Forms.TextBox();
            this.lblPeminjam = new System.Windows.Forms.Label();
            this.cmbPeminjam = new System.Windows.Forms.ComboBox();
            this.lblTglPinjam = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTglKembali = new System.Windows.Forms.Label();
            this.dtpTglKembali = new System.Windows.Forms.DateTimePicker();
            this.lblKodeAlat = new System.Windows.Forms.Label();
            this.txtKodeAlat = new System.Windows.Forms.TextBox();
            this.btnCariAlat = new System.Windows.Forms.Button();
            this.lblNamaAlat = new System.Windows.Forms.Label();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.btnTambahItem = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(20, 15);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(212, 25);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Transaksi Peminjaman";
            // 
            // lblNoTransaksi
            // 
            this.lblNoTransaksi.AutoSize = true;
            this.lblNoTransaksi.Location = new System.Drawing.Point(22, 58);
            this.lblNoTransaksi.Name = "lblNoTransaksi";
            this.lblNoTransaksi.Size = new System.Drawing.Size(77, 13);
            this.lblNoTransaksi.TabIndex = 1;
            this.lblNoTransaksi.Text = "No. Transaksi:";
            // 
            // txtNoTransaksi
            // 
            this.txtNoTransaksi.Location = new System.Drawing.Point(115, 55);
            this.txtNoTransaksi.Name = "txtNoTransaksi";
            this.txtNoTransaksi.ReadOnly = true;
            this.txtNoTransaksi.Size = new System.Drawing.Size(200, 20);
            this.txtNoTransaksi.TabIndex = 2;
            // 
            // lblPeminjam
            // 
            this.lblPeminjam.AutoSize = true;
            this.lblPeminjam.Location = new System.Drawing.Point(22, 92);
            this.lblPeminjam.Name = "lblPeminjam";
            this.lblPeminjam.Size = new System.Drawing.Size(84, 13);
            this.lblPeminjam.TabIndex = 3;
            this.lblPeminjam.Text = "Nama Peminjam:";
            // 
            // cmbPeminjam
            // 
            this.cmbPeminjam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeminjam.FormattingEnabled = true;
            this.cmbPeminjam.Location = new System.Drawing.Point(115, 89);
            this.cmbPeminjam.Name = "cmbPeminjam";
            this.cmbPeminjam.Size = new System.Drawing.Size(200, 21);
            this.cmbPeminjam.TabIndex = 4;
            this.cmbPeminjam.DropDown += new System.EventHandler(this.cmbPeminjam_DropDown);
            // 
            // lblTglPinjam
            // 
            this.lblTglPinjam.AutoSize = true;
            this.lblTglPinjam.Location = new System.Drawing.Point(440, 58);
            this.lblTglPinjam.Name = "lblTglPinjam";
            this.lblTglPinjam.Size = new System.Drawing.Size(64, 13);
            this.lblTglPinjam.TabIndex = 5;
            this.lblTglPinjam.Text = "Tgl. Pinjam:";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(545, 55);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(220, 20);
            this.dtpTanggal.TabIndex = 6;
            // 
            // lblTglKembali
            // 
            this.lblTglKembali.AutoSize = true;
            this.lblTglKembali.Location = new System.Drawing.Point(440, 92);
            this.lblTglKembali.Name = "lblTglKembali";
            this.lblTglKembali.Size = new System.Drawing.Size(95, 13);
            this.lblTglKembali.TabIndex = 7;
            this.lblTglKembali.Text = "Rencana Kembali:";
            // 
            // dtpTglKembali
            // 
            this.dtpTglKembali.CustomFormat = "dd MMMM yyyy";
            this.dtpTglKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTglKembali.Location = new System.Drawing.Point(545, 89);
            this.dtpTglKembali.Name = "dtpTglKembali";
            this.dtpTglKembali.Size = new System.Drawing.Size(220, 20);
            this.dtpTglKembali.TabIndex = 8;
            // 
            // lblKodeAlat
            // 
            this.lblKodeAlat.AutoSize = true;
            this.lblKodeAlat.Location = new System.Drawing.Point(22, 140);
            this.lblKodeAlat.Name = "lblKodeAlat";
            this.lblKodeAlat.Size = new System.Drawing.Size(56, 13);
            this.lblKodeAlat.TabIndex = 9;
            this.lblKodeAlat.Text = "Kode Alat:";
            // 
            // txtKodeAlat
            // 
            this.txtKodeAlat.Location = new System.Drawing.Point(115, 137);
            this.txtKodeAlat.Name = "txtKodeAlat";
            this.txtKodeAlat.Size = new System.Drawing.Size(120, 20);
            this.txtKodeAlat.TabIndex = 10;
            // 
            // btnCariAlat
            // 
            this.btnCariAlat.Location = new System.Drawing.Point(241, 135);
            this.btnCariAlat.Name = "btnCariAlat";
            this.btnCariAlat.Size = new System.Drawing.Size(74, 23);
            this.btnCariAlat.TabIndex = 11;
            this.btnCariAlat.Text = "Cari";
            this.btnCariAlat.UseVisualStyleBackColor = true;
            this.btnCariAlat.Click += new System.EventHandler(this.btnCariAlat_Click);
            // 
            // lblNamaAlat
            // 
            this.lblNamaAlat.AutoSize = true;
            this.lblNamaAlat.Location = new System.Drawing.Point(340, 140);
            this.lblNamaAlat.Name = "lblNamaAlat";
            this.lblNamaAlat.Size = new System.Drawing.Size(59, 13);
            this.lblNamaAlat.TabIndex = 12;
            this.lblNamaAlat.Text = "Nama Alat:";
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(405, 137);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.ReadOnly = true;
            this.txtNamaAlat.Size = new System.Drawing.Size(160, 20);
            this.txtNamaAlat.TabIndex = 13;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(585, 140);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(32, 13);
            this.lblStok.TabIndex = 14;
            this.lblStok.Text = "Stok:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(623, 137);
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(45, 20);
            this.txtStok.TabIndex = 15;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(685, 140);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(26, 13);
            this.lblJumlah.TabIndex = 16;
            this.lblJumlah.Text = "Qty:";
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(717, 137);
            this.nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(48, 20);
            this.nudJumlah.TabIndex = 17;
            this.nudJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTambahItem
            // 
            this.btnTambahItem.Location = new System.Drawing.Point(115, 170);
            this.btnTambahItem.Name = "btnTambahItem";
            this.btnTambahItem.Size = new System.Drawing.Size(120, 28);
            this.btnTambahItem.TabIndex = 18;
            this.btnTambahItem.Text = "+ Tambah Item";
            this.btnTambahItem.UseVisualStyleBackColor = true;
            this.btnTambahItem.Click += new System.EventHandler(this.btnTambahItem_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(25, 212);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(740, 200);
            this.dgvCart.TabIndex = 19;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(22, 430);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(65, 13);
            this.lblKeterangan.TabIndex = 20;
            this.lblKeterangan.Text = "Keterangan:";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(100, 427);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(380, 45);
            this.txtKeterangan.TabIndex = 21;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(555, 432);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 38);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(665, 432);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 38);
            this.btnBatal.TabIndex = 23;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 490);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnTambahItem);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtNamaAlat);
            this.Controls.Add(this.lblNamaAlat);
            this.Controls.Add(this.btnCariAlat);
            this.Controls.Add(this.txtKodeAlat);
            this.Controls.Add(this.lblKodeAlat);
            this.Controls.Add(this.dtpTglKembali);
            this.Controls.Add(this.lblTglKembali);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblTglPinjam);
            this.Controls.Add(this.cmbPeminjam);
            this.Controls.Add(this.lblPeminjam);
            this.Controls.Add(this.txtNoTransaksi);
            this.Controls.Add(this.lblNoTransaksi);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Transaksi Peminjaman Alat";
            this.Activated += new System.EventHandler(this.FormTransaksi_Activated);
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNoTransaksi;
        private System.Windows.Forms.TextBox txtNoTransaksi;
        private System.Windows.Forms.Label lblPeminjam;
        private System.Windows.Forms.ComboBox cmbPeminjam;
        private System.Windows.Forms.Label lblTglPinjam;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblTglKembali;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.Label lblKodeAlat;
        private System.Windows.Forms.TextBox txtKodeAlat;
        private System.Windows.Forms.Button btnCariAlat;
        private System.Windows.Forms.Label lblNamaAlat;
        private System.Windows.Forms.TextBox txtNamaAlat;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Button btnTambahItem;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}