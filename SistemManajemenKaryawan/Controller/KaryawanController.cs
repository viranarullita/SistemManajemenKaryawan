using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.Controller
{
    internal class KaryawanController : Model.Connection
    {
        public DataTable TampilKaryawan()
        {
            DataTable data = new DataTable();
            try
            {
                string query = @"
                SELECT k.id, k.nama, k.jenis_kelamin, k.no_hp, k.posisi, 
                       d.nama_dept AS departemen, k.statuss, k.tanggal_bergabung
                FROM karyawan k 
                LEFT JOIN departemen d ON k.id_dept = d.id_dept";
                da = new MySqlDataAdapter(query, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public void TambahKaryawan(string nama, string jenisKelamin, string noHp, string posisi, int? idDept, DateTime tanggalBergabung, string status)
        {
            string query = "INSERT INTO karyawan (nama, jenis_kelamin, no_hp, posisi, id_dept, tanggal_bergabung, statuss) VALUES (@nama, @jenis_kelamin, @no_hp, @posisi, @id_dept, @tanggal_bergabung, @status)";

            try
            {
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@jenis_kelamin", MySqlDbType.VarChar).Value = jenisKelamin;
                cmd.Parameters.Add("@no_hp", MySqlDbType.VarChar).Value = noHp;
                cmd.Parameters.Add("@posisi", MySqlDbType.VarChar).Value = posisi;
                cmd.Parameters.Add("@id_dept", MySqlDbType.Int32).Value = (object)idDept ?? DBNull.Value; 
                cmd.Parameters.Add("@tanggal_bergabung", MySqlDbType.Date).Value = tanggalBergabung;
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateKaryawan(int id, string nama, string jenisKelamin, string noHp, string posisi, int? idDept, DateTime tanggalBergabung, string status)
        {
            string query = @"
                UPDATE karyawan 
                SET nama = @nama, jenis_kelamin = @jenis_kelamin, no_hp = @no_hp, 
                    posisi = @posisi, id_dept = @id_dept, 
                    tanggal_bergabung = @tanggal_bergabung, statuss = @status 
                WHERE id = @id";

            try
            {
                using (var connection = GetConn())
                using (var command = new MySqlCommand(query, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nama", nama);
                    command.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin);
                    command.Parameters.AddWithValue("@no_hp", noHp);
                    command.Parameters.AddWithValue("@posisi", posisi);
                    command.Parameters.AddWithValue("@id_dept", idDept.HasValue ? idDept : null);
                    command.Parameters.AddWithValue("@tanggal_bergabung", tanggalBergabung);
                    command.Parameters.AddWithValue("@status", status);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HapusKaryawan(int id)
        {
            string hapus = "DELETE FROM karyawan WHERE id = @id";

            try
            {
                cmd = new MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hapus data gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable AmbilDataDepartemen()
        {
            DataTable data = new DataTable();
            string query = "SELECT id_dept, nama_dept FROM departemen";

            try
            {
                using (var connection = GetConn())
                using (var adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public DataTable CariKaryawan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT k.id, k.nama, k.jenis_kelamin, k.no_hp, k.posisi, " +
                    "d.nama_dept AS departemen, k.tanggal_bergabung, k.statuss " +
                    "FROM karyawan k " +
                    "LEFT JOIN departemen d ON k.id_dept = d.id_dept " +
                    "WHERE CONCAT(k.id, k.nama, k.jenis_kelamin, k.no_hp, k.posisi, d.nama_dept) " +
                    "LIKE '%" + search + "%'", GetConn());

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public int HitungTotalKaryawan()
        {
            string query = "SELECT COUNT(*) FROM Karyawan";
            try
            {
                using (var connection = GetConn())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar(); 
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menghitung total karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; 
            }
        }

        public int HitungKaryawanAktif()
        {
            string query = "SELECT COUNT(*) FROM Karyawan WHERE statuss = 'Aktif'";
            try
            {
                using (var connection = GetConn())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); 
                    }
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result); 
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menghitung karyawan aktif: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int HitungKaryawanNonaktif()
        {
            string query = "SELECT COUNT(*) FROM Karyawan WHERE statuss = 'Nonaktif'";
            try
            {
                using (var connection = GetConn())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); 
                    }
                    using (var command = new MySqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result); 
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menghitung karyawan nonaktif: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public DateTime GetTanggalBergabung(int idKaryawan)
        {
            DateTime tanggalBergabung = DateTime.MinValue;
            try
            {
                string query = "SELECT tanggal_bergabung FROM karyawan WHERE id = @id_karyawan";
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@id_karyawan", MySqlDbType.Int32).Value = idKaryawan;

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    tanggalBergabung = (DateTime)result;
                }
                else
                {
                    tanggalBergabung = DateTime.MinValue; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil tanggal bergabung: " + ex.Message);
            }
            return tanggalBergabung;
        }
    }
}