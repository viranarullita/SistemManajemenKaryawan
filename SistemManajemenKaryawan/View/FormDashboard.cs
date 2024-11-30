using SistemManajemenKaryawan.Controller;
using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormDashboard : Form
    {
        private KaryawanController karyawanController; 
        public FormDashboard()
        {
            InitializeComponent();
            karyawanController = new KaryawanController();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                label_totalKaryawan.Text = karyawanController.HitungTotalKaryawan().ToString();
                label_karyawanAktif.Text = karyawanController.HitungKaryawanAktif().ToString();
                label_karyawanNonaktif.Text = karyawanController.HitungKaryawanNonaktif().ToString();
            }
            catch 
            {
                MessageBox.Show("Error memuat data dashboard");
            }
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Hide();
        }
    }
}
