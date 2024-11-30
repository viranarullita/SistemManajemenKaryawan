using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.Controller
{
    internal class DepartemenController : Model.Connection
    {
        public DataTable TampilDepartemen()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM departemen";
                da = new MySqlDataAdapter(query, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public void TambahDepartemen(string namaDept)
        {
            try
            {
                string query = "INSERT INTO departemen (nama_dept) VALUES (@nama_dept)";
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@nama_dept", MySqlDbType.VarChar).Value = namaDept;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDepartemen(int idDept, string namaDept)
        {
            try
            {
                string query = "UPDATE departemen SET nama_dept = @nama_dept WHERE id_dept = @id_dept";
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@id_dept", MySqlDbType.Int32).Value = idDept;  // Menambahkan ID departemen
                cmd.Parameters.Add("@nama_dept", MySqlDbType.VarChar).Value = namaDept; // Mengupdate nama departemen
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HapusDepartemen(int idDept)
        {
            try
            {
                string query = "DELETE FROM departemen WHERE id_dept = @id_dept";
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@id_dept", MySqlDbType.Int32).Value = idDept;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus departemen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
