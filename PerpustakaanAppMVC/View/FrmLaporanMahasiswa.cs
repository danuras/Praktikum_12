using System;
using System.Windows.Forms;
using System.Collections.Generic;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Controller;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmLaporanMahasiswa : Form
    {
        // deklarasi objek controller
        private MahasiswaController controller;

        public FrmLaporanMahasiswa()
        {
            InitializeComponent();
            InisialisasiListView();

            controller = new MahasiswaController();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = System.Windows.Forms.View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Npm", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 350, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Angkatan", 80, HorizontalAlignment.Center);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
                TampilkanSemuaData();

            else if (rdoBerdasarkanNama.Checked)
                TampilkanBerdasarkanNama(txtNama.Text);

            else if (rdoBerdasarkanNim.Checked)
                TampilkanBerdasarkanNpm(txtNpm.Text);
        }

        private void TampilkanSemuaData()
        {
            // kosongkan listview
            lvwMahasiswa.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            List<Mahasiswa> listOfMahasiswa = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var mhs in listOfMahasiswa)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwMahasiswa.Items.Add(item);
            }
        }

        private void TampilkanBerdasarkanNama(string nama)
        {
            // kosongkan listview
            lvwMahasiswa.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            List<Mahasiswa> listOfMahasiswa = controller.ReadByNama(nama);

            // ekstrak objek mhs dari collection
            foreach (var mhs in listOfMahasiswa)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwMahasiswa.Items.Add(item);
            }
        }

        private void TampilkanBerdasarkanNpm(string npm)
        {
            // kosongkan listview
            lvwMahasiswa.Items.Clear();

            // panggil method ReadByNpm dan tampung datanya ke dalam collection
            Mahasiswa mhs = controller.ReadByNpm(npm);

            if (mhs != null)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwMahasiswa.Items.Add(item);
            }
        }
    }
}
