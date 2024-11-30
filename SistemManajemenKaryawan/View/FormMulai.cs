using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormMulai : Form
    {
        public FormMulai()
        {
            InitializeComponent();
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            FormSignIn masuk = new FormSignIn();
            masuk.Show();
            this.Hide();
        }
    }
}
