using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace _27_ChatClient
{
    public partial class Form1 : Form
    {
        private string Username;
        private StreamWriter stwWriter;
        private StreamReader strReader;
        private TcpClient tcpServer;

        private delegate void UpdateLogCallBack(string strMessage);
        private delegate void CloseConnectionCallBack(string strReason);
        private Thread msgThread;
        private IPAddress ipAddress;
        private int port;
        private bool Connected;

        public Form1()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Connected)
            {
                StartConnetion();
            }
            else
            {
                CloseConnection("Form closed by user!");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendMessage();
            }
        }

        private void StartConnetion()
        {
            try
            {
                ipAddress = IPAddress.Parse(txtIP.Text);
                port = (int)txtPort.Value;

                tcpServer = new TcpClient();
                tcpServer.Connect(ipAddress, port);

                Connected = true;
                Username = txtUser.Text;

                txtIP.Enabled = false;
                txtPort.Enabled = false;
                txtUser.Enabled = false;
                txtMessage.Enabled = true;
                btnConnect.Text = "Disconnect";

                stwWriter = new StreamWriter(tcpServer.GetStream());
                stwWriter.WriteLine(txtUser.Text);
                stwWriter.Flush();

                msgThread = new Thread(new ThreadStart(ReceiveMessages));
                msgThread.Start();
                msgThread.IsBackground = true;

                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.Text = "Connected to Server!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }));
            }
            catch (Exception ex)
            {
                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.Text = ex.Message;
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }));
            }
        }

        private void ReceiveMessages()
        {
            strReader = new StreamReader(tcpServer.GetStream());
            string ConResponse = strReader.ReadLine();
            if (ConResponse[0] == '1')
            {
                this.Invoke(new UpdateLogCallBack(this.UpdateLog), new object[] { "Connected Successfully!" });
            }
            else
            {
                string Reason = "Not Connected: ";
                Reason += ConResponse.Substring(2, ConResponse.Length - 2);
                this.Invoke(new CloseConnectionCallBack(this.CloseConnection), new object[] { Reason });
                return;
            }
            while (Connected)
            {
                this.Invoke(new UpdateLogCallBack(this.UpdateLog), new object[] { strReader.ReadLine() });
            }
        }

        private void UpdateLog(string strMessage)
        {
            txtChat.Text += strMessage + "\r\n";
        }

        private void SendMessage()
        {
            if (txtMessage.Lines.Length >= 1)
            {
                stwWriter.WriteLine(txtMessage.Text);
                stwWriter.Flush();
                txtMessage.Lines = null;
            }
            txtMessage.Text = "";
        }

        private void CloseConnection(string Reason)
        {
            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.Text = Reason;
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }));

            txtIP.Enabled = true;
            txtPort.Enabled = true;
            txtUser.Enabled = true;
            txtMessage.Enabled = false;
            btnConnect.Text = "Connect";
            btnConnect.ForeColor = System.Drawing.Color.Green;
            
            Connected = false;
            stwWriter.Close();
            strReader.Close();
            tcpServer.Close();
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Connected)
            {
                Connected = false;
                stwWriter.Close();
                strReader.Close();
                tcpServer.Close();
            }

            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.Text = "Application Closed!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }));
        }
    }
}
