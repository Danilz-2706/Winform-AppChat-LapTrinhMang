using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class join_group
    {
        private int id_group;
        public int Idgroup { get => id_group; set => id_group = value; }

        private int id_user;
        public int Iduser { get => id_user; set => id_user = value; }

       

        public join_group()
        {
        }

        public join_group(int id_user, int id_group)
        {
            this.id_group = id_group;
            this.id_user = id_user;
        }
    }
}
