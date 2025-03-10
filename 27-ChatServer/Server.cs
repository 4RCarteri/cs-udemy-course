using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _27_ChatServer
{
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    class Server
    {
        //Store the users and conections (accessed by user)
        public static Hashtable htUsers = new Hashtable(30); // 30 users at one time limit

        // Store user and connections (accessed by connection)
        public static Hashtable htConnections = new Hashtable(30);

        // Store IP
        private IPAddress ipAddress;
        private int port;
        private TcpClient tcpClient;

        // The event and its argument will notify the form when a user has connected, disconnected, send message, etc.
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        public Server(IPAddress ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
        }

        // The thread that will hold the connection listener
        private Thread thrListener;

        // The TCP object that listens for connections
        private TcpListener tlsClient;

        // The event and its argument will notify the form when a user has connected, disconnected, send message, etc.
        bool ServRunning = false;

        public static void IncludeUser(TcpClient tcpUser, string strUsername)
        {
            // First add the username and associated connection to both hash tables
            Server.htUsers.Add(strUsername, tcpUser);
            Server.htConnections.Add(tcpUser, strUsername);
            // Tell of the new connection to all other users and to the server form
            SendAdminMessage(htConnections[tcpUser] + " has joined us");
        }

        public static void RemoveUser(TcpClient tcpUser)
        {
            // If the user is there
            if (htConnections[tcpUser] != null)
            {
                // First show the information and tell the other users about the disconnection
                SendAdminMessage(htConnections[tcpUser] + " has left us");
                // Remove the user from the hash table
                Server.htUsers.Remove(Server.htConnections[tcpUser]);
                Server.htConnections.Remove(tcpUser);
            }
        }

        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;
            if (statusHandler != null)
            {
                // Invoke the delegate
                statusHandler(null, e);
            }
        }

        public static void SendAdminMessage(string Message)
        {
            StreamWriter swSenderSender;
            e = new StatusChangedEventArgs("Administrator: " + Message);
            OnStatusChanged(e);
            TcpClient[] tcpClients = new TcpClient[Server.htUsers.Count];
            Server.htUsers.Values.CopyTo(tcpClients, 0);
            for (int i = 0; i < tcpClients.Length; i++)
            {
                try
                {
                    if (Message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }
                    swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                    swSenderSender.WriteLine("Administrator: " + Message);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch
                {
                    RemoveUser(tcpClients[i]);
                }
            }
        }

        public static void SendMessage(string From, string Message)
        {
            StreamWriter swSenderSender;
            e = new StatusChangedEventArgs(From + " says: " + Message);
            OnStatusChanged(e);
            TcpClient[] tcpClients = new TcpClient[Server.htUsers.Count];
            Server.htUsers.Values.CopyTo(tcpClients, 0);
            for (int i = 0; i < tcpClients.Length; i++)
            {
                try
                {
                    if (Message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }
                    swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                    swSenderSender.WriteLine(From + " says: " + Message);
                    swSenderSender.Flush();
                    swSenderSender = null;
                }
                catch
                {
                    RemoveUser(tcpClients[i]);
                }
            }
        }

        public void StartListening()
        {
            try
            {
                IPAddress ipALocal = ipAddress;
                int localPort = port;
                // Create the TCP listener object using the IP of the server and the specified port
                TcpListener tlsClient = new TcpListener(ipALocal, localPort);
                // Start the TCP listener and listen for connections
                tlsClient.Start();
                // The while loop will check for true in this before checking for connections
                ServRunning = true;
                // Start the new tread that hosts the listener
                thrListener = new Thread(KeepListening);
                thrListener.IsBackground = true;
                thrListener.Start();
            } catch { }
           
        }

        private void KeepListening()
        {
            // While the server is running
            while (ServRunning)
            {
                // Accept a pending connection
                tcpClient = tlsClient.AcceptTcpClient();
                // Create a new instance of Connection
                Connection newConnection = new Connection(tcpClient);
            }
        }
    }
}
