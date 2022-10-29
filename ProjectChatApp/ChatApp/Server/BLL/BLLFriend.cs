using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;
using Server.DTO;
using System.Windows.Forms;
using Server.DAL;

namespace Server.BLL
{
    public class BLLFriend
    {
        DALFriend dalFriend = new DALFriend();
        public List<int> getFriendByID(int id)
        {
            List<int> list = dalFriend.getFriendByID(id);
            if(list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
    }
   
}
