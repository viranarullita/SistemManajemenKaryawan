using MySqlConnector;
using SistemManajemenKaryawan.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.Controller
{
    internal class LoginController : Model.Connection
    {
        private Connection connect = new Connection();
        public DataTable GetList(MySqlCommand command)
        {
            command.Connection = connect.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public void TambahAdmin(string username, string pasword)
        {
            string add = "INSERT INTO admin VALUES(" + "@username,@pasword)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pasword", MySqlConnector.MySqlDbType.VarChar).Value = pasword;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal " + ex.Message);
            }
        }
    }
}
