using SistemManajemenKaryawan.Controller;
using SistemManajemenKaryawan.View;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan
{
    public partial class FormSignIn : Form
    {
        LoginController loginControl;
        public FormSignIn()
        {
            loginControl = new LoginController();
            InitializeComponent();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if ((TextBox_username.Text == "") || (TextBox_password.Text == ""))
            {
                MessageBox.Show("Butuh login data", "login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = TextBox_username.Text;
                string pasword = TextBox_password.Text;
                DataTable table = loginControl.GetList(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM admin WHERE username = '" + name + "' AND pasword ='" + pasword + "'"));

                if (table.Rows.Count > 0)
                {
                    FormHome beranda = new FormHome();
                    this.Hide();
                    beranda.Show();
                }
                else
                {
                    MessageBox.Show("Username dan Password tidak ada", "login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            FormSignUp daftar = new FormSignUp();
            daftar.Show();
            this.Hide();
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox_show_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_password.PasswordChar = CheckBox_show.Checked ? '\0' : '*';
        }
    }
}
