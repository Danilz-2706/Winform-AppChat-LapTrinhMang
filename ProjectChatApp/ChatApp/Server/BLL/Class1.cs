using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    internal class Class1
    {
        public void test() {

            BLLFriend bll = new BLLFriend();
            List<int> list = bll.getFriendByID(2);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
