using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class viewmessage
    {
        private int iduser;
        private int idmess;

        public viewmessage()
        {

        }
        public viewmessage(int iduser, int idmess)
        {
            this.iduser = iduser;
            this.idmess = idmess;
        }
        public int Iduser { get => iduser; set => iduser = value; }
        public int Idmess { get => idmess; set => idmess = value; }


    }
}
