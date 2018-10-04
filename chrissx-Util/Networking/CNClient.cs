using System.IO;
using System.Net.Sockets;
using System.Text;

namespace chrissx_Util.Networking
{
    class CNClient
    {
        private int version = 001;
        private string ver = ".NET Visual C# Version 0.0.1";
        TcpClient c;
        StreamWriter w;
        StreamReader r;

        public CNClient(string address, int port)
        {
            c = new TcpClient(address, port);
            w = new StreamWriter(c.GetStream(), Encoding.UTF8);
            r = new StreamReader(c.GetStream(), Encoding.UTF8);
            w.AutoFlush = true;
        }

        public void Send(string s)
        {
            w.WriteLine(s);
        }
    }
}
