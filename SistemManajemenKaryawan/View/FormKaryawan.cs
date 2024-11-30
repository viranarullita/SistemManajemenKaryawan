using SistemManajemenKaryawan.Controller;
using SistemManajemenKaryawan.Validation;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.View
{
    public partial class FormKaryawan : Form
    {
        private KaryawanController karyawanController;

        public FormKaryawan()
        {
            karyawanController = new KaryawanController();
            InitializeComponent();
        }

        private void FormKaryawan_Load(object sender, EventArgs e)
        {
            showKaryawan();
            loadDepartemen();
        }

        private void showKaryawan()
        {
            try
            {
                DataTable karyawanData = karyawanController.TampilKaryawan();
                DataGridView_karyawan.DataSource = karyawanData;
                DataGridView_karyawan.ClearSelection();

                if (karyawanData.Rows.Count == 0)
                {
                    MessageBox.Show("Data karyawan tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataGridView_karyawan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDepartemen()
        {
            try
            {
                DataTable departemenData = karyawanController.AmbilDataDepartemen();

                if (departemenData.Rows.Count > 0)
                {
                    ComboBox_idDept.DataSource = departemenData;
                    ComboBox_idDept.DisplayMember = "nama_dept";
                    ComboBox_idDept.ValueMember = "id_dept";
                    ComboBox_idDept.SelectedIndex = -1;
                }
                else
                {
                    ComboBox_idDept.DataSource = null;
                    ComboBox_idDept.Items.Add("Data tidak tersedia");
                    ComboBox_idDept.SelectedIndex = 0;
                    ComboBox_idDept.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyInput()
        {
            Validasi validasi = new Validasi();

            if (!validasi.ValidasiNama(TextBox_nama.Text) || !validasi.ValidasiNohp(TextBox_nohp.Text) ||
                !validasi.ValidasiPosisi(TextBox_posisi.Text) || TextBox_nama.Text == "" ||
                TextBox_nohp.Text == "" || TextBox_posisi.Text == "" || ComboBox_jeniskel.SelectedIndex < 0 ||
                ComboBox_status.SelectedIndex < 0 || ComboBox_idDept.SelectedIndex < 0 )
            {
                return false;
            }

            if (DateTimePicker_bergabung.Value > DateTime.Now)
            {
                MessageBox.Show("Tanggal bergabung tidak boleh lebih dari tanggal hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;  
            }
            return true;  
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (VerifyInput())
            {
                try
                {
                    karyawanController.TambahKaryawan(
                        TextBox_nama.Text,
                        ComboBox_jeniskel.SelectedItem.ToString(),
                        TextBox_nohp.Text,
                        TextBox_posisi.Text,
                        Convert.ToInt32(ComboBox_idDept.SelectedValue),
                        DateTimePicker_bergabung.Value,
                        ComboBox_status.SelectedItem.ToString()
                    );

                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showKaryawan();
                    Button_clear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambah data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap lengkapi semua input.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            if (VerifyInput())
            {
                if (TextBox_idKaryawan.Text == "")
                {
                    MessageBox.Show("ID karyawan tidak ditemukan untuk diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(TextBox_idKaryawan.Text, out int id))
                {
                    try
                    {
                        karyawanController.UpdateKaryawan(
                            id,
                            TextBox_nama.Text,
                            ComboBox_jeniskel.SelectedItem.ToString(),
                            TextBox_nohp.Text,
                            TextBox_posisi.Text,
                            Convert.ToInt32(ComboBox_idDept.SelectedValue),
                            DateTimePicker_bergabung.Value,
                            ComboBox_status.SelectedItem.ToString()
                        );
                        MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showKaryawan();
                        Button_clear_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID karyawan tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Harap lengkapi semua input.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_idKaryawan.Text, out int id))
            {
                DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data ini?","Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning );

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        karyawanController.HapusKaryawan(id);
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showKaryawan();
                        Button_clear_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ID karyawan tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox_idKaryawan.Text = "";            
            TextBox_nama.Clear();
            ComboBox_jeniskel.SelectedIndex = -1;
            TextBox_nohp.Clear();
            TextBox_posisi.Clear();
            ComboBox_idDept.SelectedIndex = -1;
            ComboBox_status.SelectedIndex = -1;
            DateTimePicker_bergabung.Value = DateTime.Today;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Hide();
        }

        private void DataGridView_karyawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_idKaryawan.Text = DataGridView_karyawan.CurrentRow.Cells[0].Value.ToString();
            TextBox_nama.Text = DataGridView_karyawan.CurrentRow.Cells[1].Value.ToString();
            ComboBox_jeniskel.Text = DataGridView_karyawan.CurrentRow.Cells[2].Value.ToString();
            TextBox_nohp.Text = DataGridView_karyawan.CurrentRow.Cells[3].Value.ToString();
            TextBox_posisi.Text = DataGridView_karyawan.CurrentRow.Cells[4].Value.ToString();
            ComboBox_idDept.Text = DataGridView_karyawan.CurrentRow.Cells[5].Value.ToString();
            ComboBox_status.Text = DataGridView_karyawan.CurrentRow.Cells[6].Value.ToString();
            try
            {
                DateTimePicker_bergabung.Value = Convert.ToDateTime(DataGridView_karyawan.CurrentRow.Cells[7].Value);
            }
            catch
            {
                DateTimePicker_bergabung.Value = DateTime.Now;
            }
        }

        private void ImageButton_search_Click(object sender, EventArgs e)
        {
            string keyword = TextBox_cari.Text.Trim();

            if (keyword != "")
            {
                try
                {
                    DataTable hasilPencarian = karyawanController.CariKaryawan(keyword);

                    if (hasilPencarian.Rows.Count > 0)
                    {
                        DataGridView_karyawan.DataSource = hasilPencarian;
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dataKaryawanLengkap = karyawanController.TampilKaryawan();  
                        DataGridView_karyawan.DataSource = dataKaryawanLengkap;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Masukkan kata kunci pencarian.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_refresh_Click(object sender, EventArgs e)
        {
            showKaryawan();
            if (TextBox_cari != null)
            {
                TextBox_cari.Clear();
            }
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
