using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void mnuMahasiswa_Click(object sender, EventArgs e)
        {
            FrmMahasiswa frm = new FrmMahasiswa();
            frm.ShowDialog();
        }

        private void mnuLaporanDaftarMahasiswa_Click(object sender, EventArgs e)
        {
            FrmLaporanMahasiswa frm = new FrmLaporanMahasiswa();
            frm.ShowDialog();
        }
    }
}
