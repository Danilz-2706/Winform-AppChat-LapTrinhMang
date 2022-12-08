using Server.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class BLLViewMessageGroup
    {
        DALViewMessageGroup DALviewmessageGroup = new DALViewMessageGroup();

        public void addViewMessage(int iduser, int idmess)
        {
            DALviewmessageGroup.addViewMessage(iduser, idmess);
        }
        public bool checkViewMessage(int iduser, int idmess)
        {
            return DALviewmessageGroup.checkViewMessage(iduser, idmess);
        }

        public List<int> checkSeenMessageUsers(int idmess)
        {
            return DALviewmessageGroup.checkTheMessageForUsers(idmess);
        }
    }
}
