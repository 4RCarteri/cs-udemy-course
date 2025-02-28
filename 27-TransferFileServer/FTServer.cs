using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _27_TransferFileServer
{
    class FTServer
    {
        static IPEndPoint IPEndPoint;
        static Socket ServerSocket;
        public static string IPAdress = "127.0.0.1";
        public static int HostPort = 1000;
        public static string HostFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public static ListBox ListMessage;

        public static void StartServer()
        {
            try
            {
                IPEndPoint = new IPEndPoint(IPAddress.Parse(IPAdress), HostPort);
                ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ServerSocket.Bind(IPEndPoint);
            }
            catch (Exception ex)
            {
                // Using invoke because we are in a different thread
                ListMessage.Invoke(new Action(() => ListMessage.Items.Add("Error: " + ex.Message)));
                ListMessage.SetSelected(ListMessage.Items.Count - 1, true);
                return;
            }

            try
            {
                ServerSocket.Listen(10);
                ListMessage.Invoke(new Action(() =>
                {
                    ListMessage.Items.Add("Server started");
                    ListMessage.Items.Add("Waiting for client...");
                    ListMessage.SetSelected(ListMessage.Items.Count - 1, true);
                }));

                Socket clientSocket = ServerSocket.Accept();
                clientSocket.ReceiveBufferSize = 16384;

                byte[] clientData = new byte[124 * 50000];
                int receivedBytesLen = clientSocket.Receive(clientData, clientData.Length, 0);
                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);

                BinaryWriter bWrite = new BinaryWriter(File.Open(HostFolder + fileName, FileMode.Append));
                bWrite.Write(clientData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);

                while (receivedBytesLen > 0)
                {
                    receivedBytesLen = clientSocket.Receive(clientData, clientData.Length, 0);
                    if (receivedBytesLen == 0)
                    {
                        bWrite.Close();
                    }
                    else
                    {
                        bWrite.Write(clientData, 0, receivedBytesLen);
                    }
                    ListMessage.Invoke(new Action(() =>
                    {
                        ListMessage.Items.Add("File received and saved as " + fileName);
                        ListMessage.SetSelected(ListMessage.Items.Count - 1, true);
                    }));
                    bWrite.Close();
                    clientSocket.Close();
                }
            }
            catch (SocketException ex)
            {
                ListMessage.Invoke(new Action(() =>
                {
                    ListMessage.Items.Add("Error to receive the file: " + ex.Message);
                    ListMessage.SetSelected(ListMessage.Items.Count - 1, true);
                }));
            }
            finally
            {
                ServerSocket.Close();
                ServerSocket.Dispose();
                StartServer();
            }
        }
    }
}
