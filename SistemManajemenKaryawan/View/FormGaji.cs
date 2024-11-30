using SistemManajemenKaryawan.Controller;
using System;
using System.Data;
using System.Windows.Forms;
using SistemManajemenKaryawan.Validation;

namespace SistemManajemenKaryawan.View
{
    public partial class FormGaji : Form
    {
        private GajiController gajiController;
        private KaryawanController karyawanController;
        private Validasi validasi;

        public FormGaji()
        {
            InitializeComponent();
            gajiController = new GajiController();
            karyawanController = new KaryawanController();
            validasi = new Validasi();
        }

        private void FormGaji_Load(object sender, EventArgs e)
        {
            ShowGaji();
            LoadKaryawanData();
        }

        private void ShowGaji()
        {
            try
            {
                DataTable data = gajiController.TampilGaji();
                DataGridView_datagaji.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void LoadKaryawanData()
        {
            try
            {
                DataTable data = gajiController.AmbilKaryawan();
                ComboBox_idKaryawan.DataSource = data;
                ComboBox_idKaryawan.DisplayMember = "id";
                ComboBox_idKaryawan.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data karyawan: " + ex.Message);
            }
        }

        private void DataGridView_datagaji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView_datagaji.CurrentRow != null)
            {
                TextBox_idgaji.Text = DataGridView_datagaji.CurrentRow.Cells[0].Value?.ToString();
                ComboBox_idKaryawan.SelectedValue = DataGridView_datagaji.CurrentRow.Cells[1].Value?.ToString();
                TextBox_gaji.Text = DataGridView_datagaji.CurrentRow.Cells[2].Value?.ToString();
                ComboBox_status.SelectedItem = DataGridView_datagaji.CurrentRow.Cells[3].Value?.ToString();
                try
                {
                    DateTimePicker_penerimaan.Value = Convert.ToDateTime(DataGridView_datagaji.CurrentRow.Cells[4].Value);
                }
                catch
                {
                    DateTimePicker_penerimaan.Value = DateTime.Now;
                }
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string gajiInput = TextBox_gaji.Text;
                if (!validasi.ValidasiGaji(gajiInput))
                {
                    return;
                }

                int idKaryawan = int.Parse(ComboBox_idKaryawan.SelectedValue.ToString());
                int gaji = int.Parse(gajiInput);

                if (ComboBox_status.SelectedItem == null)
                {
                    MessageBox.Show("Harap pilih status Gaji", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string status = ComboBox_status.SelectedItem.ToString();

                DateTime tanggalPenerimaan = DateTimePicker_penerimaan.Checked ? DateTimePicker_penerimaan.Value : DateTime.MinValue;
                DateTime tanggalBergabung = karyawanController.GetTanggalBergabung(idKaryawan);

                if (tanggalPenerimaan < tanggalBergabung)
                {
                    MessageBox.Show("Tanggal penerimaan gaji tidak boleh lebih awal dari tanggal bergabung karyawan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                gajiController.TambahGaji(idKaryawan, gaji, status, tanggalPenerimaan);
                MessageBox.Show("Data berhasil ditambahkan.");
                ShowGaji();
                Button_clear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                string gajiInput = TextBox_gaji.Text;
                if (!validasi.ValidasiGaji(gajiInput))
                {
                    return;
                }

                int idGaji = int.Parse(TextBox_idgaji.Text);
                int idKaryawan = int.Parse(ComboBox_idKaryawan.SelectedValue.ToString());
                int gaji = int.Parse(gajiInput);

                if (ComboBox_status.SelectedItem == null)
                {
                    MessageBox.Show("Harap pilih status Gaji");
                    return;
                }
                string status = ComboBox_status.SelectedItem.ToString();

                DateTime tanggalPenerimaan = DateTimePicker_penerimaan.Checked ? DateTimePicker_penerimaan.Value : DateTime.MinValue;

                gajiController.UpdateGaji(idGaji, idKaryawan, gaji, status, tanggalPenerimaan);

                MessageBox.Show("Data berhasil diperbarui.");
                ShowGaji(); 
                Button_clear_Click(sender, e); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idGaji = int.Parse(TextBox_idgaji.Text);
                gajiController.DeleteGaji(idGaji);
                MessageBox.Show("Data berhasil dihapus.");
                ShowGaji();
                Button_clear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox_idgaji.Text = "";
            ComboBox_idKaryawan.SelectedIndex = -1;
            TextBox_gaji.Clear();
            ComboBox_status.SelectedIndex = -1;
            DateTimePicker_penerimaan.Value = DateTime.Now;
            DateTimePicker_penerimaan.Checked = false;
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
