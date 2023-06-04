using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CLIENTBMS
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        TcpClient client = new TcpClient();

        private void btnStart_Click(object sender, EventArgs e)
        {
            // START BUTTON 
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                Random rnd = new Random();
                int port = rnd.Next(8002, 8100);
                IPEndPoint point = new IPEndPoint(IPAddress.Loopback, port);
                client = new TcpClient(point);
                client.Connect(IPAddress.Loopback, 8001);
                lblIP.Text = point.Address.ToString() + " : " + point.Port.ToString();
                Thread t = new Thread(Readmessage);
                t.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("CHANGE PORT NUMBER ");
            }
        }

        public void Readmessage()
        {
            while (true)
            {
                NetworkStream stream = client.GetStream();
                StreamReader sdr = new StreamReader(stream);
                string mg = sdr.ReadLine();
                rtxtReceiver.AppendText(Environment.NewLine);
                rtxtReceiver.AppendText("Server:  " + mg);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // SEND BUTTON
            rtxtClient.AppendText(Environment.NewLine);
            rtxtClient.AppendText("Client: " + txtMessage.Text);
            NetworkStream stream = client.GetStream();
            StreamWriter sdr = new StreamWriter(stream);
            sdr.WriteLine(txtMessage.Text);
            sdr.Flush();
            txtMessage.Clear();
        }
    }
}
