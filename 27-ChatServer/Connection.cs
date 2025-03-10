using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _27_ChatServer
{
    class Connection
    {
        TcpClient client;
        private Thread thrSender;
        private StreamReader srReceiver;
        private StreamWriter swSender;
        private string currUser;
        private string strResponse;

        public Connection(TcpClient tcpCon)
        {
            client = tcpCon;
            // The thread that accepts the client and awaits messages
            thrSender = new Thread(AcceptClient);
            thrSender.IsBackground = true;
            // The thread calls the AcceptClient() method
            thrSender.Start();
        }

        private void CloseConnection()
        {
            // Close the currently open objects
            client.Close();
            srReceiver.Close();
            swSender.Close();
        }

        private void AcceptClient()
        {
            srReceiver = new StreamReader(client.GetStream());
            swSender = new StreamWriter(client.GetStream());
            // Read the user's name
            currUser = srReceiver.ReadLine();
            // We got a response from the user
            if (currUser != "")
            {
                // Store the user name in the hash table
                if (Server.htUsers.ContainsValue(currUser))
                {
                    // 0 means the name is invalid
                    swSender.WriteLine("0|This username already exists.");
                    swSender.Flush();
                    CloseConnection();
                    return;
                }
                else if (currUser == "Administrator")
                {
                    // 0 means the name is invalid
                    swSender.WriteLine("0|This username is reserved.");
                    swSender.Flush();
                    CloseConnection();
                    return;
                }
                else
                {
                    // 1 means the name is valid
                    swSender.WriteLine("1");
                    swSender.Flush();
                    // Add the user to the hash tables and start listening for messages from him
                    Server.htUsers.Add(currUser, client);
                    Server.htConnections.Add(client, currUser);
                }
            }
            else
            {
                CloseConnection();
                return;
            }

            try
            {
                while((strResponse = srReceiver.ReadLine()) != "")
                {
                    if(strResponse == null)
                    {
                        Server.RemoveUser(client);
                    }
                    else
                    {
                        Server.SendMessage(currUser, strResponse);
                    }
                }
            }
            catch
            {
                Server.RemoveUser(client);
            }
        }
    }
}
