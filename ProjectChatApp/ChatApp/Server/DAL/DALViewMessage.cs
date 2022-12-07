using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class DALViewMessage
    {
        public void addViewMessage(int iduser,int idmess)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "Insert INTO view_message_11 (id_user,id_mess) " +
                    "VALUES(@iduser,@idmess)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@iduser", iduser);
                    cmd.Parameters.AddWithValue("@idmess", idmess);                  
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }

        public bool checkViewMessage(int iduser,int idmess)
        {
            bool check = false;
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "SELECT * FROM `view_message_11` WHERE id_user='"+iduser+"' and id_mess='"+idmess+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if(dataReader.Read())
                {                 
                    check = true;
                }
                else                                           
                    check = false;                            
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return check;
        }

        public List<int> checkTheMessageForUsers(int idmess)
        {
            List<int> list = new List<int>();
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "SELECT * FROM view_message_11 where id_mess='"+idmess+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int t = 0;
                    t = dataReader.GetInt32("id_user");
                    list.Add(t);
                }
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return list;
        }
    }
}
