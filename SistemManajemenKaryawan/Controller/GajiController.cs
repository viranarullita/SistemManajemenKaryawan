using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.Controller
{
    internal class GajiController : Model.Connection
    {
        public DataTable TampilGaji()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM gaji";
                da = new MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void TambahGaji(int idKaryawan, int gaji, string status, DateTime tanggalPenerimaan)
        {
            string tambah = "INSERT INTO gaji (id_karyawan, gaji, statuss, tanggal_penerimaan) " +
                            "VALUES (@id_karyawan, @gaji, @status, @tanggal_penerimaan)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_karyawan", MySqlDbType.Int32).Value = idKaryawan;
                cmd.Parameters.Add("@gaji", MySqlDbType.Int32).Value = gaji;
                cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = status;
                cmd.Parameters.Add("@tanggal_penerimaan", MySqlDbType.Date).Value = tanggalPenerimaan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah data gaji : " + ex.Message);
            }
        }

        public void UpdateGaji(int idGaji, int idKaryawan, int gaji, string status, DateTime? tanggalPenerimaan)
        {
            string update = "UPDATE gaji SET id_karyawan=@id_karyawan, gaji=@gaji, statuss=@status, tanggal_penerimaan=@tanggal_penerimaan WHERE id_gaji=@id_gaji";
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_gaji", MySqlDbType.Int32).Value = idGaji; 
                cmd.Parameters.Add("@id_karyawan", MySqlDbType.Int32).Value = idKaryawan; 
                cmd.Parameters.Add("@gaji", MySqlDbType.Int32).Value = gaji; 
                cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = status; 
                cmd.Parameters.Add("@tanggal_penerimaan", MySqlDbType.Date).Value = (object)tanggalPenerimaan ?? DBNull.Value;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data gaji: " + ex.Message);
            }
        }

        public void DeleteGaji(int idGaji)
        {
            string delete = "DELETE FROM gaji WHERE id_gaji=@id_gaji";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_gaji", MySqlDbType.Int32).Value = idGaji;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data gaji: " + ex.Message);
            }
        }

        public DataTable AmbilKaryawan()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id FROM karyawan"; 
                da = new MySqlDataAdapter(query, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data karyawan: " + ex.Message);
            }
            return data;
        }
    }
}
