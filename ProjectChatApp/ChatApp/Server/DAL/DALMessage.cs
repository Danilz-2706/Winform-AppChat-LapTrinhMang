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
        public void addMessage(int idsender, int idreceiver,string messagecontent, int url)
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
    }
}
