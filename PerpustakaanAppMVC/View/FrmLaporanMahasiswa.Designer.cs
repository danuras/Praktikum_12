namespace PerpustakaanAppMVC.View
{
    partial class FrmLaporanMahasiswa
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
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanNama = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanNim = new System.Windows.Forms.RadioButton();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNpm = new System.Windows.Forms.TextBox();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Location = new System.Drawing.Point(12, 12);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(113, 17);
            this.rdoSemua.TabIndex = 0;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua mahasiswa";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanNama
            // 
            this.rdoBerdasarkanNama.AutoSize = true;
            this.rdoBerdasarkanNama.Location = new System.Drawing.Point(12, 36);
            this.rdoBerdasarkanNama.Name = "rdoBerdasarkanNama";
            this.rdoBerdasarkanNama.Size = new System.Drawing.Size(114, 17);
            this.rdoBerdasarkanNama.TabIndex = 1;
            this.rdoBerdasarkanNama.TabStop = true;
            this.rdoBerdasarkanNama.Text = "Berdasarkan nama";
            this.rdoBerdasarkanNama.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanNim
            // 
            this.rdoBerdasarkanNim.AutoSize = true;
            this.rdoBerdasarkanNim.Location = new System.Drawing.Point(12, 59);
            this.rdoBerdasarkanNim.Name = "rdoBerdasarkanNim";
            this.rdoBerdasarkanNim.Size = new System.Drawing.Size(110, 17);
            this.rdoBerdasarkanNim.TabIndex = 2;
            this.rdoBerdasarkanNim.TabStop = true;
            this.rdoBerdasarkanNim.Text = "Berdasarkan Npm";
            this.rdoBerdasarkanNim.UseVisualStyleBackColor = true;
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.Location = new System.Drawing.Point(12, 84);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(583, 371);
            this.lvwMahasiswa.TabIndex = 3;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(132, 35);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(231, 20);
            this.txtNama.TabIndex = 4;
            // 
            // txtNpm
            // 
            this.txtNpm.Location = new System.Drawing.Point(132, 58);
            this.txtNpm.Name = "txtNpm";
            this.txtNpm.Size = new System.Drawing.Size(105, 20);
            this.txtNpm.TabIndex = 4;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(378, 12);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(118, 64);
            this.btnTampilkanData.TabIndex = 5;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // FrmLaporanMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 470);
            this.Controls.Add(this.btnTampilkanData);
            this.Controls.Add(this.txtNpm);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lvwMahasiswa);
            this.Controls.Add(this.rdoBerdasarkanNim);
            this.Controls.Add(this.rdoBerdasarkanNama);
            this.Controls.Add(this.rdoSemua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLaporanMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSemua;
        private System.Windows.Forms.RadioButton rdoBerdasarkanNama;
        private System.Windows.Forms.RadioButton rdoBerdasarkanNim;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNpm;
        private System.Windows.Forms.Button btnTampilkanData;
    }
}