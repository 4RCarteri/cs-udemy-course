using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace _27_TransferFileClient
{
    class FTClient
    {
        static IPEndPoint ClientIP;
        static Socket ClientSocket;
        public static string IPAddress = "127.0.0.1";
        public static int HostPort;
        public static string FolderFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static Label LabelMessage;

        public static void SendFile(string file)
        {
            try
            {
                ClientIP = new IPEndPoint(System.Net.IPAddress.Parse(IPAddress), HostPort);
                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                string folder = file.Substring(0, file.LastIndexOf(@"\") + 1);
                file = file.Substring(file.LastIndexOf(@"\") + 1);

                ClientSocket.Connect(ClientIP);
                byte[] fileName = Encoding.ASCII.GetBytes(file);

                if (fileName.Length > 50000 * 1024)
                {
                    LabelMessage.Invoke(new Action(() =>
                    {
                        LabelMessage.BackColor = Color.Red;
                        LabelMessage.Text = "File size is too large";
                    }));
                    return;
                }
                string fullPath = folder + file;

                byte[] fileData = File.ReadAllBytes(fullPath);
                byte[] clientData = new byte[4 + fileName.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileName.Length);

                fileNameLen.CopyTo(clientData, 0);
                fileName.CopyTo(clientData, 0);
                fileData.CopyTo(clientData, 4 + fileName.Length);
                ClientSocket.Connect(ClientIP);
                ClientSocket.Send(clientData, 0, clientData.Length, 0);
                ClientSocket.Close();

                LabelMessage.Invoke(new Action(() =>
                {
                    LabelMessage.ForeColor = Color.Green;
                    LabelMessage.Text = "The file has been sent";
                }));
            }
            catch (Exception ex)
            {
                LabelMessage.Invoke(new Action(() =>
                {
                    LabelMessage.ForeColor = Color.Red;
                    LabelMessage.Text = ex.Message;
                }));
            }
            finally
            {
                ClientSocket.Disconnect(false);
                ClientSocket.Close();
            }
        }
    }
}
