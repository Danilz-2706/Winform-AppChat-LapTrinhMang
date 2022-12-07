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


        public List<int> getFriendRequestByID(int id)
        {
            List<int> list = dalFriend.getFriendRequestByID(id);
            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }

        public List<int> getFriendReponseOffByID(int id)
        {
            List<int> list = dalFriend.getMyReponseOffByID(id);
            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
        public List<int> getMyRequestByID(int id)
        {
            List<int> list = dalFriend.getMyRequestByID(id);
            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }


        public void addFriend(int id_user1, int id_user2, int status)
        {

            dalFriend.addFriend(id_user1, id_user2, status);

        }

        public void updateStatusFriend(int id_user1, int id_user2, int status)
        {

            dalFriend.updateStatusFriend(id_user1, id_user2, status);

        }

        public void deleteFriendRequest(int id_user1, int id_user2)
        {

            dalFriend.deleteFriendRequest(id_user1, id_user2);

        }
    }
   
}
