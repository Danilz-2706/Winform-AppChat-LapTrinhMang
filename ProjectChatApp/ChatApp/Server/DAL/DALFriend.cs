using MySql.Data.MySqlClient;
using Server.DTO;
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


        // lấy những người đã gửi lời mời kết bạn tới mình
        public List<int> getFriendRequestByID(int idUserReponse)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            List<int> listFriend = new List<int>();
            try
            {
                string query = "SELECT id_user_1 FROM friend WHERE id_user_2='" + idUserReponse + "' and id_user_1 not in (SELECT id_user_2 from friend WHERE id_user_1='" + idUserReponse + "')";
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

        //lấy những người mình đã gửi lời mời kết bạn 
        public List<int> getMyRequestByID(int idUserReponse)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            List<int> listFriend = new List<int>();
            try
            {
                string query = "SELECT id_user_2 FROM friend WHERE id_user_1='" + idUserReponse + "' and id_user_2 not in (SELECT id_user_1 from friend WHERE id_user_2='" + idUserReponse + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    listFriend.Add(dataReader.GetInt32("id_user_2"));

                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return listFriend;
        }

        public List<int> getMyReponseOffByID(int idUserRequest)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            List<int> listFriend = new List<int>();
            try
            {
                string query = "SELECT id_user_1 FROM friend WHERE id_user_2='" + idUserRequest + "' and id_user_1 in (SELECT id_user_2 from friend WHERE id_user_1='" + idUserRequest + "') and status=0";
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


        public void addFriend(int id_user1, int id_user2, int status)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {

                string query = "INSERT INTO friend(id_user_1, id_user_2, status) VALUES (@id_user1,@id_user2,@status)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user1", id_user1);
                    cmd.Parameters.AddWithValue("@id_user2", id_user2);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }

        //UPDATE friend SET status=1 WHERE id_user_1=10 AND id_user_2=11

        public void updateStatusFriend(int id_user1, int id_user2, int status)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {

                string query = "UPDATE friend SET status=@status WHERE id_user_1=@id_user1 AND id_user_2=@id_user2";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user1", id_user1);
                    cmd.Parameters.AddWithValue("@id_user2", id_user2);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }

        //DELETE FROM friend WHERE id_user_1=11 AND id_user_2=12

        public void deleteFriendRequest(int id_user1, int id_user2)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {

                string query = "DELETE FROM friend WHERE id_user_1=@id_user1 AND id_user_2=@id_user2";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user1", id_user1);
                    cmd.Parameters.AddWithValue("@id_user2", id_user2);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }

    }
}
