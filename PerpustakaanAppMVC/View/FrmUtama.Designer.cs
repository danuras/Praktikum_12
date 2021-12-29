namespace PerpustakaanAppMVC.View
{
    partial class FrmUtama
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
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMahasiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuku = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPengarang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPenerbit = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksiPeminjaman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksiPengembalian = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporanDaftarMahasiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referensiToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMahasiswa,
            this.mnuBuku,
            this.mnuPengarang,
            this.mnuPenerbit});
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.referensiToolStripMenuItem.Text = "Referensi";
            // 
            // mnuMahasiswa
            // 
            this.mnuMahasiswa.Name = "mnuMahasiswa";
            this.mnuMahasiswa.Size = new System.Drawing.Size(132, 22);
            this.mnuMahasiswa.Text = "Mahasiswa";
            this.mnuMahasiswa.Click += new System.EventHandler(this.mnuMahasiswa_Click);
            // 
            // mnuBuku
            // 
            this.mnuBuku.Name = "mnuBuku";
            this.mnuBuku.Size = new System.Drawing.Size(132, 22);
            this.mnuBuku.Text = "Buku";
            // 
            // mnuPengarang
            // 
            this.mnuPengarang.Name = "mnuPengarang";
            this.mnuPengarang.Size = new System.Drawing.Size(132, 22);
            this.mnuPengarang.Text = "Pengarang";
            // 
            // mnuPenerbit
            // 
            this.mnuPenerbit.Name = "mnuPenerbit";
            this.mnuPenerbit.Size = new System.Drawing.Size(132, 22);
            this.mnuPenerbit.Text = "Penerbit";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransaksiPeminjaman,
            this.mnuTransaksiPengembalian});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // mnuTransaksiPeminjaman
            // 
            this.mnuTransaksiPeminjaman.Name = "mnuTransaksiPeminjaman";
            this.mnuTransaksiPeminjaman.Size = new System.Drawing.Size(201, 22);
            this.mnuTransaksiPeminjaman.Text = "Transaksi Peminjaman";
            // 
            // mnuTransaksiPengembalian
            // 
            this.mnuTransaksiPengembalian.Name = "mnuTransaksiPengembalian";
            this.mnuTransaksiPengembalian.Size = new System.Drawing.Size(201, 22);
            this.mnuTransaksiPengembalian.Text = "Transaksi Pengembalian";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLaporanDaftarMahasiswa});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // mnuLaporanDaftarMahasiswa
            // 
            this.mnuLaporanDaftarMahasiswa.Name = "mnuLaporanDaftarMahasiswa";
            this.mnuLaporanDaftarMahasiswa.Size = new System.Drawing.Size(180, 22);
            this.mnuLaporanDaftarMahasiswa.Text = "Daftar Mahasiswa";
            this.mnuLaporanDaftarMahasiswa.Click += new System.EventHandler(this.mnuLaporanDaftarMahasiswa_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Informasi Perpustakaan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMahasiswa;
        private System.Windows.Forms.ToolStripMenuItem mnuBuku;
        private System.Windows.Forms.ToolStripMenuItem mnuPengarang;
        private System.Windows.Forms.ToolStripMenuItem mnuPenerbit;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksiPeminjaman;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksiPengembalian;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporanDaftarMahasiswa;
    }
}