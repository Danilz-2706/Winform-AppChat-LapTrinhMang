using DTO.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class DALMessage
    {
        public void addMessage(int idsender, int idreceiver,string messagecontent, string url)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "Insert INTO message_11 (id_sender,id_received,content,url) " +
                    "VALUES(@idsender,@idreceiver,@messagecontent,@url)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idsender", idsender);
                    cmd.Parameters.AddWithValue("@idreceiver", idreceiver);             
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
        public void addImage(int idsender, int idreceiver, string messagecontent, string url)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "Insert INTO message_11 (id_sender,id_received,content,url) " +
                    "VALUES(@idsender,@idreceiver,@messagecontent,@url)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idsender", idsender);
                    cmd.Parameters.AddWithValue("@idreceiver", idreceiver);
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

        public List<message> getHistoryChat(int idsender,int idrev) 
        {
            List<message> temp = new List<message>();
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "SELECT * from message_11 " +
                    "where id_sender ='"+idsender+"' and id_received = '"+idrev+"' OR id_sender ='"+idrev+"' and id_received = '"+idsender+"' " +
                    "ORDER BY message_11.time";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    message mess = new message();
                    mess.Id = dataReader.GetInt32("id");
                    mess.Idsender = dataReader.GetInt32("id_sender");
                    mess.Idreceiver = dataReader.GetInt32("id_received");
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
        public List<message> getHistoryImageChat(int idsender, int idrev)
        {
            List<message> temp = new List<message>();
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {
                string query = "SELECT * from message_11 " +
                    "where id_sender ='" + idsender + "' and id_received = '" + idrev + "' OR id_sender ='" + idrev + "' and id_received = '" + idsender + "' " +
                    "ORDER BY message_11.time";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    message mess = new message();
                    mess.Id = dataReader.GetInt32("id");
                    mess.Idsender = dataReader.GetInt32("id_sender");
                    mess.Idreceiver = dataReader.GetInt32("id_received");
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
