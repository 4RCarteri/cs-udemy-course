using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TransferFileServer
{
    public partial class Form1: Form
    {
        Task task;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkFolder.Text = FTServer.HostFolder;
            FTServer.ListMessage = logsList;
        }

        private void connectServer_Click(object sender, EventArgs e)
        {
            try
            {
                FTServer.HostPort = (int)inputPort.Value;
                FTServer.IPAdress = txtBoxIP.Text;
                task = Task.Factory.StartNew(() => {
                    FTServer.StartServer();
                });
            }
            catch (Exception ex)
            {
                logsList.Invoke(new Action(() => logsList.Items.Add("Error: " + ex.Message)));
                logsList.SetSelected(logsList.Items.Count - 1, true);
            }
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }catch(Exception ex)
            {
                logsList.Invoke(new Action(() => logsList.Items.Add("Error: " + ex.Message)));
                logsList.SetSelected(logsList.Items.Count - 1, true);
            }
        }

        private void linkFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.HostFolder = dialog.SelectedPath + @"\";
                linkFolder.Text = dialog.SelectedPath;
            }
        }
    }
}
