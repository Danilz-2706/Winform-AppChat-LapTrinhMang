using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class view_message_group
    {
        private int iduser;
        private int idmess;

        public view_message_group()
        {

        }
        public view_message_group(int iduser, int idmess)
        {
            this.iduser = iduser;
            this.idmess = idmess;
        }
        public int Iduser { get => iduser; set => iduser = value; }
        public int Idmess { get => idmess; set => idmess = value; }
    }
}
