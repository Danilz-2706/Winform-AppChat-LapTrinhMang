using DTO.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class DALMessageGroup
    {
        public void addMessageGroup(int idUser, int idGroup, string messagecontent, string url)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "Insert INTO message_group (id_user,id_group,content,url) " +
                    "VALUES(@id_user,@id_group,@messagecontent,@url)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@id_group", idGroup);
                    cmd.Parameters.AddWithValue("@messagecontent", messagecontent);
                    cmd.Parameters.AddWithValue("@url", url);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }

        public List<message_group> getHistoryChat(int idUser, int idGroup)
        {
            List<message_group> temp = new List<message_group>();
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "SELECT * from message_group " +
                    "where id_user ='" + idUser + "' and id_group = '" + idGroup + "' OR id_user ='" + idGroup + "' and id_group = '" + idUser + "' " +
                    "ORDER BY message_group.time";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    message_group mess = new message_group();
                    mess.Id = dataReader.GetInt32("id");
                    mess.IdUser = dataReader.GetInt32("id_user");
                    mess.IdGroup = dataReader.GetInt32("id_group");
                    mess.Time = dataReader.GetMySqlDateTime("time").ToString();
                    mess.Messagecontent = dataReader.GetString("content");
                    mess.Url = dataReader.GetInt16("url");
                    temp.Add(mess);

                }
            }
            catch (Exception)
            {

                throw;
            }
            conn.Clone();
            return temp;
        }
    }
}
