using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class group
    {
        private int id_group;
        public int Idgroup { get => id_group; set => id_group = value; }

        private int id_owner;
        public int Idowner { get => id_owner; set => id_owner = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        public group()
        {
        }

        public group(int id_group, int id_owner, string name)
        {
            this.id_group = id_group;
            this.id_owner = id_owner;
            this.name = name;
        }

    }
}
