using Server.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class BLLGroup
    {
        DALGroup DALgroup = new DALGroup();

        public void createGroup(int idGroup, int idOwner, string name)
        {
            DALgroup.createGroup(idGroup, idOwner, name);
        }

        public void addmember(int idUser, int idGroup)
        {
            DALgroup.addMember(idUser, idGroup);
        }

    }
}
