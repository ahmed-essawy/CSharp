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

namespace Lab12_Server
{
    public partial class Form1 : Form
    {
        private NetworkStream nStream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private TcpListener listener;
        private Thread connect_thread;
        private Socket connection;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(Connects));
            thread.Start();
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
                disconnect();
            }
        }

        public void Connects()
        {
            if (listener == null)
                listener = new TcpListener(new IPAddress(new byte[] { 127, 0, 0, 1 }), 1025);
            listener.Start();
            connection = listener.AcceptSocket();
            if (connection.Connected == true)
            {
                label1.Text = "Connected";
                nStream = new NetworkStream(connection);
                reader = new BinaryReader(nStream);
                writer = new BinaryWriter(nStream);
                connect_thread = new Thread(new ThreadStart(DataRead));
                connect_thread.Start();
                listBox1.Items.Clear();
                textBox1.Text = String.Empty;
                textBox1.Enabled = true;
            }
            while (connection.Connected)
                if (connection.Poll(1000, SelectMode.SelectRead) && connection.Available == 0)
                    disconnect();
        }

        private void Send_Button(object sender, EventArgs e)
        {
            try
            {
                writer.Write(textBox1.Text);
                listBox1.Items.Add("Me: " + textBox1.Text);
                textBox1.Text = String.Empty;
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        public void disconnect()
        {
            connect_thread.Abort();
            reader.Close();
            writer.Close();
            nStream.Close();
            connection.Shutdown(SocketShutdown.Both);
            connection.Close();
            textBox1.Enabled = false;
            label1.Text = String.Empty;

            listener.Stop();
            Connects();
        }
    }
}