using DTO.DTO;
using Server.DTO;
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

    public class REQUESTHISTORYCHAT
    {
        public REQUESTHISTORYCHAT(int idsender, int idrec)
        {
            this.idsender = idsender;
            this.idrec = idrec;
        }
        public int idsender { get; set; }
        public int idrec { get; set; }
    }

    public class SENDHISTORYCHAT
    {
        public SENDHISTORYCHAT(List<message> listHistoryChat)
        {
            this.listHistoryChat = listHistoryChat;
        }
        public List<message>? listHistoryChat { get; set; }
    }

    public class SENDMESSAGE
    {
        public SENDMESSAGE(int idsender, int idrec, string? contentmess, string? url)
        {
            this.idsender = idsender;
            this.idrec = idrec;
            this.contentmess = contentmess;
            this.url = url;
        }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public string? contentmess { get; set; }
        public string? url { get; set; }
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
        public LOGIN(string? username, string? pass)
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
    public class SENDUSERSTATUS
    {
        public SENDUSERSTATUS(user u)
        {
            this.u = u;
        }

        public user? u { get; set; }
    }


    public class LOGINSUCESS
    {
        public LOGINSUCESS(int? id, string? email, string? password, string? name, int? sex, string? bd, int? online_status, int? is_active, int? server_block, List<user> listFriendOfUser, List<user> listFriendRequestOfUser, List<string> listUsernaemReponseOff)
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
            this.listFriendOfUser = listFriendOfUser;
            this.listFriendRequestOfUser = listFriendRequestOfUser;
            this.listUsernaemReponseOff = listUsernaemReponseOff;
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

        public List<user>? listFriendOfUser { get; set; }
        public List<user>? listFriendRequestOfUser { get; set; }
        public List<string>? listUsernaemReponseOff { get; set; }
    }


    public class SENFRIENDREQUEST
    {
        public SENFRIENDREQUEST(int? id, string? usernameRequest)
        {
            this.id = id;
            this.usernameRequest = usernameRequest;
        }

        public string? usernameRequest { get; set; }
        public int? id { get; set; }

    }

    public class SENFRIENDREPONSE
    {
        public SENFRIENDREPONSE(int idReponse, int idRequest)
        {
            this.idReponse = idReponse;
            this.idRequest = idRequest;
        }

        public int idReponse { get; set; }
        public int idRequest { get; set; }

    }


    public class SENUPDATEFRIEND
    {
        public SENUPDATEFRIEND(int id)
        {
            this.id = id;
           
        }

        public int id { get; set; }
        

    }


}