using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Packet
{
    public class Packet
    {
        public Packet(string mess, string? content)
        {
            this.mess = mess;
            this.content = content;
        }
        public string mess { get; set; }
        public string? content { get; set; }
        
    }
    public class EXIT
    {
        public EXIT(string username, string? content)
        {
            this.username = username;
            this.content = content;
        }

        public string username { get; set; }
        public string? content { get; set; }
    }
    public class LOGIN
    {
        public LOGIN(string ? username,string ? pass)
        {
            this.username = username;
            this.pass = pass;
        }
        public string? username { get; set; }
        public string? pass { get; set; }
    }

    public class REGISTER
    {
        public REGISTER(string? username, string? pass, string? confirmpass, string? name, int? sex, string? bd)
        {
            this.username = username;
            this.pass = pass;
            this.confirmpass = confirmpass;
            this.name = name;
            this.sex = sex;
            this.bd = bd;
        }
        public string? username { get; set; }
        public string? pass { get; set; }
        public string? confirmpass { get; set; }
        public string? name { get; set; }
        public int? sex { get; set; }
        public string? bd { get; set; }
    }


    public class LOGINSUCESS
    {

    }
    public class SENDMESSAGE
    {
        public SENDMESSAGE(string ? usernameSender, string ? usernameReceiver, string ? content)
        {
            this.usernameSender = usernameSender;
            this.usernameReceiver = usernameReceiver;
            this.content = content;
        }
        public string? usernameSender { get; set; }
        public string? usernameReceiver { get; set; }
        public string? content { get; set; }
    }
}