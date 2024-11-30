using SistemManajemenKaryawan.Controller;
using SistemManajemenKaryawan.Validation;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormDepartemen : Form
    {
        private DepartemenController departemenController;
        public FormDepartemen()
        {
            InitializeComponent();
            departemenController = new DepartemenController();
        }

        private void FormDepartemen_Load(object sender, EventArgs e)
        {
            ShowDepartemen();
        }

        private void ShowDepartemen()
        {
            try
            {
                DataTable data = departemenController.TampilDepartemen();
                DataGridView_departemen.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_departemen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_iddept.Text = DataGridView_departemen.CurrentRow.Cells[0].Value?.ToString();
            TextBox_namadept.Text = DataGridView_departemen.CurrentRow.Cells[1].Value?.ToString();
        }

        private bool verifyInputDept()
        {
            Validasi validasi = new Validasi();

            if (TextBox_namadept.Text == "")
            {
                MessageBox.Show("Nama departemen tidak boleh kosong.");
                return false;
            }

            if (!validasi.ValidasiNamaDept(TextBox_namadept.Text))
            {
                return false;
            }
            return true;
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (verifyInputDept())
            {
                try
                {
                    departemenController.TambahDepartemen(TextBox_namadept.Text);
                    MessageBox.Show("Departemen berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDepartemen();
                    Button_clear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambah departemen: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap lengkapi semua input dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            if (verifyInputDept()) 
            {
                try
                {
                    int idDept = int.TryParse(TextBox_iddept.Text, out idDept) ? idDept : 0;
                    if (idDept > 0)
                    {
                        departemenController.UpdateDepartemen(idDept, TextBox_namadept.Text); 
                        MessageBox.Show("Departemen berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDepartemen();
                        Button_clear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("ID Departemen tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap perbaiki input nama departemen.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox_iddept.Text = "";
            TextBox_namadept.Clear();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Hide();
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
