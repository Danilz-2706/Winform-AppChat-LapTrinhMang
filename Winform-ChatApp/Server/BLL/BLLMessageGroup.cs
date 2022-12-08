using DTO.DTO;
using Server.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class BLLMessageGroup
    {
        DALMessageGroup DALMessGroup = new DALMessageGroup();

        public void addMessageGroup(int idUser, int idGroup, string messagecontent, string url)
        {
            DALMessGroup.addMessageGroup(idUser, idGroup, messagecontent, url);
        }

        public List<message_group> getHistoryChat(int idUser, int idGroup)
        {
            return DALMessGroup.getHistoryChat(idUser, idGroup);
        }


    }
}
