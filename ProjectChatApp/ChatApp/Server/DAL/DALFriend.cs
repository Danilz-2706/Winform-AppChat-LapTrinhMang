using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class DALFriend
    {

        public List<int> getFriendByID(int id)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            List<int> listFriend = new List<int>();
            try
            {
                string query = "SELECT id_user_1 FROM friend WHERE id_user_2='" + id + "' and id_user_1 in (SELECT id_user_2 from friend WHERE id_user_1='" + id + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    listFriend.Add(dataReader.GetInt32("id_user_1"));

                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return listFriend;
        }


        public List<int> getFriendRequestByID(int id)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            List<int> listFriend = new List<int>();
            try
            {
                string query = "select id_user_1 from friend where id_user_2='"+id+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    listFriend.Add(dataReader.GetInt32("id_user_1"));

                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return listFriend;
        }
      


    }
}
