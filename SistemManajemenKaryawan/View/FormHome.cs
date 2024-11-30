using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Button_karyawan_Click(object sender, EventArgs e)
        {
            FormKaryawan karyawan = new FormKaryawan();
            karyawan.Show();
            this.Hide();
        }

        private void Button_departemen_Click(object sender, EventArgs e)
        {
            FormDepartemen departemen = new FormDepartemen();
            departemen.Show();
            this.Hide();
        }

        private void Button_gaji_Click(object sender, EventArgs e)
        {
            FormGaji gaji = new FormGaji();
            gaji.Show();
            this.Hide();
        }

        private void Button_about_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.Show();
            this.Hide();
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            DialogResult tanya = MessageBox.Show("Apakah Anda yakin ingin keluar akun?","Konfirmasi Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (tanya == DialogResult.Yes)
            {
                FormSignIn masuk = new FormSignIn();
                masuk.Show();
                this.Hide();
            }
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            DialogResult tanya = MessageBox.Show("Apakah Anda yakin ingin keluar Aplikasi?", "Konfirmasi Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tanya == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button_dashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
