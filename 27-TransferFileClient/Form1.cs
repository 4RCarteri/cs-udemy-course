using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TransferFileClient
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            FTClient.LabelMessage = lblStatus;
        }

        private void inkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                linkFile.Text = dialog.FileName;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIP.Text) ||
                string.IsNullOrEmpty(numPort.Value.ToString()) ||
                linkFile.Text == "Select a file")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please fill in all fields";
                return;
            }

            FTClient.IPAddress = txtIP.Text;
            FTClient.HostPort = (int)numPort.Value;

            try
            {
                Task.Factory.StartNew(() =>
                {
                    FTClient.SendFile(linkFile.Text);
                });

            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }
    }
}
