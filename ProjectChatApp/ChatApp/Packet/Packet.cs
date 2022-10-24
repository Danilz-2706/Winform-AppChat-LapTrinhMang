using System.ComponentModel;
using System.Reflection.Metadata;
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
        public LOGINSUCESS(int? id, string? email, string? password, string? name, int? sex, string? bd, int? online_status, int? is_active, int? server_block)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.sex = sex;
            this.bd = bd;
            this.online_status = online_status;
            this.is_active = is_active;
            this.server_block = server_block;
        }

        public int? id { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? name { get; set; }
        public int? sex { get; set; }
        public string? bd { get; set; }
        public int? online_status { get; set; }
        public int? is_active { get; set; }
        public int? server_block { get; set; }
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