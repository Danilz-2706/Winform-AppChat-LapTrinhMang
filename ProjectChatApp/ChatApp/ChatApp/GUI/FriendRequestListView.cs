using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.GUI
{
    public partial class FriendRequestListView : UserControl
    {

        private string username;
     
        private int idRespone;
        private int idRequest;
        private Socket server;
        public FriendRequestListView()
        {
            InitializeComponent();
        }
        public FriendRequestListView(int idRespone, int idRequest, Socket server)
        {
            InitializeComponent();
            this.idRespone = idRespone;
            this.idRequest = idRequest;
            this.server = server;
        }


        [Category("CustomPros")]
        public string Username
        {
            get { return username; }
            set { username = value; UsernameRequestlbl.Text = value; }
        }
        private void FriendRequestListView_Load(object sender, EventArgs e)
        {

        }

        private void sendJson(object obj)
        {
            try
            {
                byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
                server.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AcceptFriendRequest(int idReponse, int idRequest)
        {
            //-------Nhận dữ liệu từ textbox và thông báo---------//
   
            byte[] data = new byte[1024];
            Packet.SENFRIENDREPONSE friendReponse = new Packet.SENFRIENDREPONSE(idReponse, idRequest);
            string jsonString = JsonSerializer.Serialize(friendReponse);
            Packet.Packet packet = new Packet.Packet("FriendReponse", jsonString);
            sendJson(packet);
            DialogResult dlr = MessageBox.Show("ban da dong y ket ban");
            //-------Kết thúc Nhận dữ liệu từ textbox và thông báo---------//
           
        }

        
        public void CancelFriendRequest(int idReponse, int idRequest)
        {
            //-------Nhận dữ liệu từ textbox và thông báo---------//

       
            Packet.SENFRIENDREPONSE friendReponse = new Packet.SENFRIENDREPONSE(idReponse, idRequest);
            string jsonString = JsonSerializer.Serialize(friendReponse);
            Packet.Packet packet = new Packet.Packet("CancelFriendReponse", jsonString);
            sendJson(packet);
            DialogResult dlr = MessageBox.Show("ban da từ choi ket ban");
            //-------Kết thúc Nhận dữ liệu từ textbox và thông báo---------//

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AcceptFriendRequest(idRespone, idRequest);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CancelFriendRequest(idRespone, idRequest);
        }
    }
}
