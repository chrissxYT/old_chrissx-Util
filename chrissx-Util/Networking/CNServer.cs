using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace chrissx_Util.Networking
{
    class CNServer
    {
        private int version = 001;
        private string ver = ".NET Visual C# Version 0.0.1";
        private TcpListener listener;
        private List<CNSocket> clients = new List<CNSocket>();
        private Thread listenerThread;
        private int SLEEP_TIME;

        public CNServer(int port, int polling_rate)
        {
            SLEEP_TIME = polling_rate;
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            listenerThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(SLEEP_TIME);
                    foreach (CNSocket s in clients)
                    {
                        String ss;
                        while ((ss = s.reader.ReadLine()) != null && ss != "")
                        {
                            //
                            //DO SOMETHING
                            //
                        }
                    }
                }
            });
            listenerThread.Name = "CNServer-ReaderThread";
            listenerThread.Start();
        }

        public void RenameClient(string currName, string newName)
        {
            CNSocket socket = GetClient(currName);
            socket.name = newName;
            clients.Add(socket);
        }

        public void AcceptClient(string name, bool threaded)
        {
            if (threaded)
            {
                Thread t = new Thread(() =>
                {
                    while (true)
                    {
                        var c = listener.AcceptTcpClient();
                        clients.Add(new CNSocket(c, name));
                    }
                });
                listenerThread.Name = "CNServer-ListenerThread";
                listenerThread.Start();
            }
            else
            {
                var c = listener.AcceptTcpClient();
                clients.Add(new CNSocket(c, name));
            }
        }

        public CNSocket GetClient(string name)
        {
            CNSocket Out = new CNSocket(null, "ERROR GETTING CNSOCKET");
            foreach (CNSocket s in clients)
            {
                if(s.name == name)
                {
                    Out = s;
                }
            }
            return Out;
        }

        public bool ClientConnected(string name)
        {
            bool Out = false;
            foreach (CNSocket s in clients)
            {
                if (s.name == name)
                {
                    Out = true;
                }
            }
            return Out;
        }

        public void Send(String s)
        {
            foreach (CNSocket so in clients)
            {
                so.writer.WriteLineAsync(s);
            }
        }

        public void Send(string s, string client)
        {
            GetClient(client).writer.WriteLine(s);
        }
    }
}
