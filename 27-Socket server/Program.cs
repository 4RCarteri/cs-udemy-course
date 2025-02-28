using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _27_Socket_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            server.Bind(endPoint);

            server.Listen(5);

            Console.WriteLine("Server is listening...");

            Socket listen = server.Accept();

            byte[] buffer = new byte[1024];

            int size = listen.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            Array.Resize(ref buffer, size);

            Console.WriteLine("Client: " + Encoding.UTF8.GetString(buffer));

            listen.Close();

            Console.WriteLine("Connection closed");
        }
    }
}
