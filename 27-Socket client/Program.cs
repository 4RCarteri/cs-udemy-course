using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _27_Socket_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
                socket.Connect(endPoint);

                Console.WriteLine("Connected to the server");
                Console.WriteLine("Enter a message to send to the server");
                string info = "Testing";

                byte[] buffer = Encoding.ASCII.GetBytes(info);
                socket.Send(buffer, 0, info.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                socket.Close();
            }
        }
    }
}
