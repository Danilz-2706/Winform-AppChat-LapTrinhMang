using MySqlX.XDevAPI;
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

namespace UI_AppChat
{
    public partial class FormCreateGroup : Form
    {
        public FormCreateGroup()
        {
            InitializeComponent();
        }
        public void CreateGroup()
        {
            string groupName = txtCreateGroup.Text;

        }
        private void sendJson(object obj)
        {
            try
            {
                byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
                _client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
