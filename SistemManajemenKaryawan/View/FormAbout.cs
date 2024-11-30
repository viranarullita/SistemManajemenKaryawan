using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
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
