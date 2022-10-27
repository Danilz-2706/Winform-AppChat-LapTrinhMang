using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class user
    {
        private int id;
        private string email;
        private string password;
        private string name;
        int sex;
        private string bd;
        int online_status;
        int is_active;
        int server_block;

        public user()
        {

        }
        public user(int id, string email, string password, string name, int sex, string bd, int online_status, int is_active, int server_block)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.sex = sex;
            this.bd = bd;
            this.online_status = online_status;
            this.is_active = is_active;
            this.server_block = server_block;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Bd { get => bd; set => bd = value; }
        public int Online_status { get => online_status; set => online_status = value; }
        public int Is_active { get => is_active; set => is_active = value; }
        public int Server_block { get => server_block; set => server_block = value; }
    }
}
