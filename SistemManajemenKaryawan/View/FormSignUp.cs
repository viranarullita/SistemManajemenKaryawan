using SistemManajemenKaryawan.Controller;
using SistemManajemenKaryawan.Validation;
using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormSignUp : Form
    {
        Validasi validation = new Validasi();
        public FormSignUp()
        {
            InitializeComponent();
        }

        bool Verify()
        {
            if (!validation.ValidasiUser(TextBox_username.Text))
                return false;

            if (!validation.ValidasiPassword(TextBox_password.Text))
                return false;

            return true;
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            LoginController loginControl = new LoginController();
            if (Verify())
            {
                loginControl.TambahAdmin(TextBox_username.Text, TextBox_password.Text);
                this.Controls.Clear();
                this.InitializeComponent();
                TextBox_username.Focus();
                MessageBox.Show("Data Disimpan");
                SistemManajemenKaryawan.FormSignIn ad = new SistemManajemenKaryawan.FormSignIn();

                ad.Show();
                this.Hide();
            }
        }

        private void Button_SignIn_Click(object sender, EventArgs e)
        {
            FormSignIn masuk = new FormSignIn();
            masuk.Show();
            this.Hide();
        }

        private void CheckBox_show_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_password.PasswordChar = CheckBox_show.Checked ? '\0' : '*';
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
