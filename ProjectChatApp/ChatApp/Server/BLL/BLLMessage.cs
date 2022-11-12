using Server.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class BLLMessage
    {
        DALMessage DALmessage = new DALMessage();
        public void addMessage(int idsender, int idreceiver, string messagecontent, int url)
        {
            DALmessage.addMessage(idsender, idreceiver, messagecontent, url);
        }
    }
}
