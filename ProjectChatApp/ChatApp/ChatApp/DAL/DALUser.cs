using ChatApp.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.DAL
{
    public class DALUser
    {
        
        public void addUser(string email,string password,string name,int sex,string bd)
        {
            MySqlConnection conn = DB.dbconnect.getconnect();
            int online_status = 0;
            int is_active = 1;
            int serverblock = 0;
            try
            {
                string query = "Insert INTO user (email,password,name,sex,birthday,online_status,is_active,ServerBlock) VALUES(@email,@password,@name,@sex,@bd,@online_status,@is_active,@serverblock)";
             
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@bd", bd);
                    cmd.Parameters.AddWithValue("@online_status", online_status);
                    cmd.Parameters.AddWithValue("@is_active", is_active);
                    cmd.Parameters.AddWithValue("@serverblock", serverblock);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }

        

       public List<user> login(string email,string pass)
       {
            MySqlConnection conn = DB.dbconnect.getconnect();
            List<user> userlist = new List<user>();            
            try
            {
                string query = "SELECT * from user ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    user u = new user();
                    u.Id = dataReader.GetInt32("Id");
                    u.Email = dataReader["email"].ToString();
                    u.Password = dataReader["password"].ToString();
                    u.Name = dataReader["name"].ToString();
                    u.Sex = dataReader.GetInt32("sex");
                    u.Bd = dataReader["birthday"].ToString();
                    u.Online_status = dataReader.GetInt32("online_status");
                    u.Is_active = dataReader.GetInt32("is_active");
                    u.Server_block = dataReader.GetInt32("ServerBlock");

                    userlist.Add(u);

                }
                
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return userlist;
       }


    }
}
