using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChatApp.DB
{
    public class dbconnect
    {
       public static MySqlConnection getconnect()
        {
            string server = "localhost";
            string database = "chatdb";
            string username = "root";
            string password = "";
            string kq = "Server=" + server + ";" + "Database=" + database + ";" +
                "Uid=" + username + ";" + "Pwd=" +password;
            
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(kq);
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the ket noi den SQL");

                throw;
            }
            return conn;
        }
        public static void closeConnection(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
