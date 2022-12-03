using DTO.DTO;
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
        public void addMessage(int idsender, int idreceiver, string messagecontent, string url)
        {
            DALmessage.addMessage(idsender, idreceiver, messagecontent, url);
        }

        public List<message> getHistoryChat(int idsender,int idrev)
        {
            return DALmessage.getHistoryChat(idsender,idrev);
        }
    }
}
