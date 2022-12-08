using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class DALGroup
    {
        public void createGroup(int idGroup, int idOwner, string name)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {

                string query = "INSERT INTO group_chat(id_group, id_owner, name) VALUES (@id_group,@id_owner,@name)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_group", idGroup);
                    cmd.Parameters.AddWithValue("@id_owner", idOwner);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }

        public void addMember(int idUser, int idGroup)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            try
            {

                string query = "INSERT INTO join_group(id_user, id_group) VALUES (@id_user,@id_group)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@id_group", idGroup);
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
