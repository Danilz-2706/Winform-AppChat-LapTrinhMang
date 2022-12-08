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
namespace UI_AppChat.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile(@"C:\Users\Public\Pictures\demo.JPG");

            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress x in ipHostInfo.AddressList)
            {
                comboBox1.Items.Add(x.ToString());
            }
        }

        public delegate void callrichtext(String ss);
        public callrichtext myDelegate;

        public void richtextappend(String s)
        {
            richTextBox1.AppendText(s);
        }

        public delegate void callrichtext2(String ss);
        public callrichtext2 myDelegate2;
        private void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            richTextBox1.Invoke(this.myDelegate, new Object[] { stringData + "\n" });
        }

        private void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
            remote.BeginReceive(data, 0, size, SocketFlags.None,
                          new AsyncCallback(ReceiveData), remote);
        }

        public void richtextappend2(String s)
        {
            richTextBox3.AppendText(s);
        }

        public delegate void buttonenable();
        public buttonenable myDelegate3;

        public void button()
        {
            button2.Enabled = true;
        }
        private Socket client;
        private byte[] data = new byte[1024000];
        private int size = 1024000;
        private OpenFileDialog y;
        private bool initialpic = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.myDelegate = new callrichtext(richtextappend);
            this.myDelegate2 = new callrichtext2(richtextappend2);
            this.myDelegate3 = new buttonenable(button);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.AppendText("Connecting... \n");
            Socket newsock = new Socket(AddressFamily.InterNetwork,
                                  SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), 9050);
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*MemoryStream ms = new MemoryStream();
           pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
           byte[] message = ms.ToArray();*/

            FileInfo fileinfo;
            byte[] message;
            FileStream fs;

            if (initialpic == true)
            {
                fileinfo = new FileInfo(@"C:\Users\Public\Pictures\demo.JPG");
                message = new byte[fileinfo.Length];
                fs = new FileStream(@"C:\Users\Public\Pictures\demo.JPG", FileMode.Open, FileAccess.Read);
            }
            else
            {
                fileinfo = new FileInfo(y.FileName);
                message = new byte[fileinfo.Length];
                fs = new FileStream(y.FileName, FileMode.Open, FileAccess.Read);
            }

            fs.Read(message, 0, message.Length);
            fs.Close();
            GC.ReRegisterForFinalize(fileinfo);
            GC.ReRegisterForFinalize(fs);

            client.BeginSend(message, 0, message.Length, SocketFlags.None,
                         new AsyncCallback(SendData), client);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.Close();
            richTextBox3.AppendText("Disconnected \n");
        }

        private void Connected(IAsyncResult iar)
        {
            client = (Socket)iar.AsyncState;
            try
            {
                client.EndConnect(iar);
                richTextBox3.Invoke(this.myDelegate2, new Object[] { "Connected to: " + client.RemoteEndPoint.ToString() + "\n" });
                client.BeginReceive(data, 0, size, SocketFlags.None,
                              new AsyncCallback(ReceiveData), client);
                button2.Invoke(this.myDelegate3, new Object[] { });
            }
            catch (SocketException)
            {
                richTextBox3.Invoke(this.myDelegate2, new Object[] { "Error connecting \n" });
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y = new OpenFileDialog();
            y.Title = "pic selection";
            y.InitialDirectory = "c:\\";
            y.Filter = "all files (*.*)|*.*|image files(*.jpg,*.bmp,*.gif)|*.jpg;*.bmp;*.gif";
            y.FilterIndex = 2;
            if (y.ShowDialog() == DialogResult.OK)
            { pictureBox1.Image = Image.FromFile(y.FileName); }

            initialpic = false;

        }
    }
}
