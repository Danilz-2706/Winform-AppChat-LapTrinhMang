using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO.DTO
{
    public class message
    {
        private int idsender;
        private int idreceiver;
        private string time;
        private string messagecontent;
        private int url;


        public message(int idsender, int idreceiver, string messagecontent, string time, int url)
        {
            this.idsender = idsender;
            this.idreceiver = idreceiver;
            this.messagecontent = messagecontent;
            this.time = time;
            this.url = url;
        }
        public message()
        {

        }

        public int Idsender { get => idsender; set => idreceiver = value; }
        public int Idreceiver { get => idreceiver; set => idreceiver = value; }
        public string Time { get => time; set => time = value; }
        public string Messagecontent { get => messagecontent; set => messagecontent = value; }
        public int Url { get => url; set => url = value; }

    }
}
