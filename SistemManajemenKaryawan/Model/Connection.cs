using MySqlConnector;
using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=manajemenkaryawan";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal" + ex.Message);
            }
            return conn;
        }
    }
}
