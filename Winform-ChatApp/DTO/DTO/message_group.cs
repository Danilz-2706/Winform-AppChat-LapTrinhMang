using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class message_group
    {
        private int id;
        private int idUser;
        private int idGroup;
        private string time;
        private string messagecontent;
        private int url;


        public message_group(int id, int idUser, int idGroup, string messagecontent, string time, int url)
        {
            this.id = id;
            this.idUser = idUser;
            this.idGroup = idGroup;
            this.messagecontent = messagecontent;
            this.time = time;
            this.url = url;
        }
        public message_group()
        {

        }

        public int IdUser { get => idUser; set => idUser = value; }
        public int IdGroup { get => idGroup; set => idGroup = value; }
        public string Time { get => time; set => time = value; }
        public string Messagecontent { get => messagecontent; set => messagecontent = value; }
        public int Url { get => url; set => url = value; }
        public int Id { get => id; set => id = value; }
    }
}
