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
        public REQUESTHISTORYCHAT(int idsender, int idrec, bool noti)
        {
            this.idsender = idsender;
            this.idrec = idrec;
            this.noti = noti;
        }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public bool noti { get; set; }
    }

    public class REQUESTHISTORYIMAGECHAT
    {
        public REQUESTHISTORYIMAGECHAT(int idsender, int idrec, bool noti)
        {
            this.idsender = idsender;
            this.idrec = idrec;
            this.noti = noti;
        }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public bool noti { get; set; }
    }

    public class SENDHISTORYCHAT
    {
        public SENDHISTORYCHAT(List<message> listHistoryChat, int idsender, int idrec, message lastmess, bool noti)
        {
            this.listHistoryChat = listHistoryChat;
            this.idsender = idsender;
            this.idrec = idrec;
            this.lastmess = lastmess;
            this.noti = noti;
        }
        public List<message>? listHistoryChat { get; set; }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public message? lastmess { get; set; }
        public bool noti { get; set; }
    }
    public class SENDHISTORYIMAGECHAT
    {
        public SENDHISTORYIMAGECHAT(List<message> listHistoryImageChat, int idsender, int idrec, message lastmess, bool noti)
        {
            this.listHistoryImageChat = listHistoryImageChat;
            this.idsender = idsender;
            this.idrec = idrec;
            this.lastmess = lastmess;
            this.noti = noti;
        }
        public List<message>? listHistoryImageChat { get; set; }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public message? lastmess { get; set; }
        public bool noti { get; set; }
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

    public class SENDIMAGE
    {
        public SENDIMAGE(int idsender, int idrec, string? contentmess, string? url)
        {
            this.idsender = idsender;
            this.idrec = idrec;
            this.contentmess = contentmess;
            this.url = url;
        }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public String? contentmess { get; set; }
        public string? url { get; set; }
    }

    public class SENDIMAGETOCLIENT
    {
        public SENDIMAGETOCLIENT(int idsender, int idrec, string? contentmess, string? url)
        {
            this.idsender = idsender;
            this.idrec = idrec;
            this.contentmess = contentmess;
            this.url = url;
        }
        public int idsender { get; set; }
        public int idrec { get; set; }
        public String? contentmess { get; set; }
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
        public LOGINSUCESS(int? id, string? email, string? password, string? name, int? sex, string? bd, int? online_status, int? is_active, int? server_block, List<user> listFriendOfUser, Dictionary<int, message> messlist)
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
            this.messlist = messlist;
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
        public Dictionary<int, message> messlist { get; set; }
    }




}