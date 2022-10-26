using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class friend
    {
        private int id_user_1;
        private int id_user_2;

        public friend()
        {
        }

        public friend(int id_user_1, int id_user_2)
        {
            this.id_user_1 = id_user_1;
            this.id_user_2 = id_user_2;
        }

        public int Id_user_1 { get => id_user_1; set => id_user_1 = value; }
        public int Id_user_2 { get => id_user_2; set => id_user_2 = value; }
    }
}
