using System;
using System.Collections;
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

namespace Bank_Management_System
{
    public partial class SERVER : Form
    {
        List<TcpClient> client = new List<TcpClient>();
        TcpListener server;
        ArrayList listt = new ArrayList();
        string FullClientName;

        public SERVER()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            server = new TcpListener(IPAddress.Loopback, 8001);
            server.Start(10);
            Thread t2 = new Thread(AcceptClient);
            t2.Start();
        }

        public void AcceptClient()
        {
            while (true)
            {
                TcpClient c = server.AcceptTcpClient();
                client.Add(c);
                IPEndPoint IPEP = (IPEndPoint)c.Client.RemoteEndPoint;
                comboBox1.Items.Add(IPEP);
                listt.Add(IPEP);
                Thread t = new Thread(asd => Readmessage(c));
                t.Start();
            }
        }
        public void Readmessage(TcpClient client)
        {
            while (true)
            {
                NetworkStream stream = client.GetStream();
                StreamReader sdr = new StreamReader(stream);
                string mg = sdr.ReadLine();

                IPEndPoint IPEP = (IPEndPoint)client.Client.RemoteEndPoint;
                FullClientName = IPEP.Address.ToString() + ":" + IPEP.Port.ToString();
                rtxtReceiver.AppendText(Environment.NewLine);
                rtxtReceiver.AppendText(FullClientName + "\t |  " + mg);
            }
        }

        private void btnSendToAll_Click(object sender, EventArgs e)
        {
            //SEND TO ALL BUTTON
            foreach (var item in client)
            {
                rtxtServer.AppendText(Environment.NewLine);
                rtxtServer.AppendText("Server: " + txtMessage.Text);
                NetworkStream stream = item.GetStream();
                StreamWriter sdr = new StreamWriter(stream);
                sdr.WriteLine(txtMessage.Text);
                sdr.Flush();
            }
            txtMessage.Clear();
        }

        private void btnSendTo_Click(object sender, EventArgs e)
        {
            //SEND TO BUTTON
            rtxtServer.AppendText(Environment.NewLine);
            rtxtServer.AppendText("Server: " + txtMessage.Text);
            string a = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (listt[i].ToString() == a)
                {
                    NetworkStream stream = client[i].GetStream();
                    StreamWriter sdr = new StreamWriter(stream);
                    sdr.WriteLine(txtMessage.Text);
                    sdr.Flush();
                    break;
                }
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            Gmail gm = new Gmail();
            this.Hide();
            gm.Show();
        }
    }
}
