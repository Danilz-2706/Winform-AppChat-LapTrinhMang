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

namespace Server.BLL
{
    public class BLLUser
    {
        DAL.DALUser DALuser = new DAL.DALUser();

        public string MD5Hash(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
        public List<user> LoadAllUser()
        {
            List<user> userList = new List<user>();
            userList = DALuser.LoadAllUser();
            return userList;
        }
        public string addAcount(string email, string password, string confirmpass, string name, int sex, string bd)
        {
            string message = "";
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);


            if (email.Equals("") && password.Equals("") && confirmpass.Equals("") && name.Equals(""))
            {
                message = "khongduocdetrong";
            }
            else if (email.Equals(""))
            {
                message = "emailtrong";
            }
            else if (password.Equals(""))
            {
                message = "passwordtrong";
            }
            else if (confirmpass.Equals(""))
            {
                message = "confirmpasstrong";
            }
            else if (name.Equals(""))
            {
                message = "nametrong";
            }

            if (!email.Equals("") && !password.Equals("") && !confirmpass.Equals("") && !name.Equals(""))
            {
                if (!match.Success)
                {
                    message = "saidinhdangemail";
                }
                else
                {
                    if (password.Equals(confirmpass))
                    {
                        string newpass = MD5Hash(password);
                        DALuser.addUser(email, newpass, name, sex, bd);
                        message = "themuserthanhcong";
                    }
                    else
                    {
                        message = "passwordvaconfirmkhongtrung";
                    }
                }

            }
            return message;
        }
        public string Login(string email, string pass)
        {
            List<user> userlist = new List<user>();
            bool flag = false;
            string newpass = MD5Hash(pass);

            string message = "";
            userlist = DALuser.login(email, newpass);

            for (int i = 0; i < userlist.Count; i++)
            {

                if (userlist[i].Email.ToString().Equals(email) && userlist[i].Password.ToString().Equals(newpass))
                {

                    flag = true;
                    break;
                }

            }
            try
            {
                if (email.Equals("") && pass.Equals(""))
                {
                    message = "khongduocdetrong";
                }
                else if (email.Equals(""))
                {
                    message = "emaildetrong";
                }
                else if (pass.Equals(""))
                {
                    message = "passdetrong";
                }
                else
                {
                    if (flag)
                    {
                        message = "dangnhapthanhcong";
                    }
                    else
                    {
                        message = "dangnhapthatbai";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

        public int getId(string email)
        {
            int id = DALuser.getId(email);
            if(id == 0)
            {
                return 0;
            }
            else
            {
                return id;
            }
        }
    }
}
