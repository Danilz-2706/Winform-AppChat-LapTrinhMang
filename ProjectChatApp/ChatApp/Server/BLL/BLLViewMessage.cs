using Server.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class BLLViewMessage
    {
        DALViewMessage DALviewmessage = new DALViewMessage();
        public void addViewMessage(int iduser, int idmess)
        {
            DALviewmessage.addViewMessage(iduser, idmess);
        }
        public bool checkViewMessage(int iduser,int idmess)
        {
            return DALviewmessage.checkViewMessage(iduser, idmess);
        }
    }
}
