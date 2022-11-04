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

        /*Hàm giả mã password MD5*/
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
        /*Hàm lấy tất cả thông tin user*/
        public List<user> LoadAllUser()
        {
            List<user> userList = new List<user>();
            userList = DALuser.LoadAllUser();
            return userList;
        }

        /*Hàm thêm 1 user (đăng ký tài khoản)*/
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
        
        /*Hàm kiểm tra thông tin đăng nhập*/
        public string Login(string email, string pass)
        {
            int active = 0;
            List<user> userlist = new List<user>();
            bool flag = false;
            string newpass = MD5Hash(pass);

            string message = "";
            userlist = DALuser.login(email, newpass);

            for (int i = 0; i < userlist.Count; i++)
            {

                if (userlist[i].Email.ToString().Equals(email) && userlist[i].Password.ToString().Equals(newpass))
                {
                    active = userlist[i].Is_active;
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
                    if (flag && active == 1)
                    {
                        message = "dangnhapthanhcong";
                    }
                    else if (flag && active == 0)
                    {
                        message = "taikhoanbikhoa";
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

        /*Hàm lấy thông tin 1 user*/ 
        public user getInfoUser(string email)
        {
            user u = new user();
            u = DALuser.getInfoUser(email);
            if(u == null)
            {
                return null;
            }
            else
            {
                return u;
            }
        }
        /*Hàm update user online status*/
        public void updateonlinestatus(int id,string act)
        {
             if(act.Equals("online") || act.Equals("offline"))
             {
                DALuser.updateonlinestatus(id,act);
             }
             else
             {
                MessageBox.Show("Sai status!!!");
             }
        }


        public user getInfoUserById(int id)
        {
            user u = new user();
            u = DALuser.getInfoUserById(id);
            if (u == null)
            {
                return null;
            }
            else
            {
                return u;
            }
        }
    }
}
