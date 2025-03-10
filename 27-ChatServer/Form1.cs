using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_ChatServer
{
    public partial class Form1: Form
    {
        private delegate void UpdateStatusCallback(string strMessage);
        bool ServRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (ServRunning)
            {
                Application.Exit();
                return;
            }

            if (txtPort.Text == "" || txtPort.Text == "0")
            {
                MessageBox.Show("Please enter a Port number");
                txtPort.Focus();
                return;
            }

            if (txtIP.Text == "")
            {
                MessageBox.Show("Please enter an IP address");
                txtIP.Focus();
                return;
            }

            try
            {
                IPAddress ipAddr = IPAddress.Parse(txtIP.Text);
                int port = (int)txtPort.Value;
                Server mainServer = new Server(ipAddr, port);

                // Hook the StatusChanged event to mainServer_StatusChanged
                Server.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);

                // Start the server
                mainServer.StartListening();

                // Show that we started the server
                listLog.Items.Add("Monitor started");
                listLog.SetSelected(listLog.Items.Count - 1, true);
            }
            catch (Exception ex)
            {
                listLog.Items.Add("Error: " + ex.Message);
                listLog.SetSelected(listLog.Items.Count - 1, true);
                return;
            }

            // Toggle the value of the server state
            ServRunning = false;
            txtIP.Enabled = false;
            txtPort.Enabled = false;
            btnStartServer.Text = "Stop Server";
            btnStartServer.BackColor = Color.Red;
        }
        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Call the method that updates the form
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            // Updates the log with the message
            listLog.Items.Add(strMessage + "\r\n");
            listLog.SetSelected(listLog.Items.Count - 1, true);
        }
    }
}
