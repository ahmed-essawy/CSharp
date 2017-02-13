using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_Client
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private NetworkStream nStream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private TcpClient client;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void DataRead()
        {
            try
            {
                while (true)
                {
                    listBox1.Items.Add("Client: " + reader.ReadString());
                }
            }
            catch (Exception)
            {
                thread.Abort();
                reader.Close();
                writer.Close();
                nStream.Close();
                client.Close();
                Connect.Text = "Connect";
                Send.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void Connect_Button(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Connect")
            {
                client = new TcpClient();
                client.Connect(new IPAddress(new byte[] { 127, 0, 0, 1 }), 1025);
                nStream = client.GetStream();
                reader = new BinaryReader(nStream);
                writer = new BinaryWriter(nStream);
                thread = new Thread(DataRead);
                thread.Start();
                ((Button)sender).Text = "Disconnect";
                Send.Enabled = true;
                listBox1.Items.Clear();
                textBox1.Text = String.Empty;
                textBox1.Enabled = true;
            }
            else
            {
                thread.Abort();
                reader.Close();
                writer.Close();
                nStream.Close();
                client.Close();
                ((Button)sender).Text = "Connect";
                Send.Enabled = false;
            }
        }

        private void Send_Button(object sender, EventArgs e)
        {
            if (nStream.CanWrite)
            {
                writer.Write(textBox1.Text);
                listBox1.Items.Add("Me: " + textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }
    }
}