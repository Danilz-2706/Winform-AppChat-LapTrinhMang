using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace Server
{
    public partial class Sever1 : Form
    {
        public Sever1()
        {
            InitializeComponent();
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());

            richTextBox1.AppendText("local server address\n");

            foreach (IPAddress x in ipHostInfo.AddressList)
            {
                richTextBox1.AppendText(x.ToString() + "\n");
            }

            server = new Socket(AddressFamily.InterNetwork,
                   SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(iep);
            server.Listen(5);
            server.BeginAccept(new AsyncCallback(AcceptConn), server);
        }

        public delegate void callrichtext(String ss);
        public callrichtext myDelegate;
        public void richtextappend(String s)
        {
            richTextBox1.AppendText(s);
        }

        private Socket server, oldclient;
        private byte[] data = new byte[10240000];
        private int size = 10240000;

        private void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            oldclient = oldserver.EndAccept(iar);
            richTextBox1.Invoke(this.myDelegate, new Object[] { "Connected to: " + oldclient.RemoteEndPoint.ToString() + "\n" });
            string stringData = "Welcome to my server";
            byte[] message1 = Encoding.ASCII.GetBytes(stringData);
            oldclient.BeginSend(message1, 0, message1.Length, SocketFlags.None,
                        new AsyncCallback(SendData), oldclient);
        }
        private void SendData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
            client.BeginReceive(data, 0, size, SocketFlags.None,
                        new AsyncCallback(ReceiveData), client);
        }

        private void SendDataBack(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
            remote.BeginReceive(data, 0, size, SocketFlags.None,
                          new AsyncCallback(ReceiveData), remote);
        }
        private void ReceiveData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int recv = client.EndReceive(iar);
            //MessageBox.Show(recv.ToString());

            if (recv == 0)
            {
                client.Close();
                richTextBox1.Invoke(this.myDelegate, new Object[] { "Waiting for client..." + "\n" });
                server.BeginAccept(new AsyncCallback(AcceptConn), server);
                return;
            }

            //MessageBox.Show(ms.ToString());
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            pictureBox1.Image = returnImage;

            string receivedData = "server has received pic";

            byte[] message2 = Encoding.ASCII.GetBytes(receivedData);
            MessageBox.Show(message2.ToString());
            client.BeginSend(message2, 0, message2.Length, SocketFlags.None,
                         new AsyncCallback(SendData), client);
        }
        private void Sever1_Load(object sender, EventArgs e)
        {
            this.myDelegate = new callrichtext(richtextappend);
        }
    }
}
