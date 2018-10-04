using System.IO;
using System.Net.Sockets;
using System.Text;

namespace chrissx_Util.Networking
{
    class CNSocket
    {
        public TcpClient client;
        public StreamWriter writer;
        public StreamReader reader;
        public string name;

        public CNSocket(TcpClient client, string name)
        {
            this.client = client;
            this.writer = new StreamWriter(client.GetStream(), Encoding.UTF8);
            this.reader = new StreamReader(client.GetStream(), Encoding.UTF8);
            this.writer.AutoFlush = true;
        }
    }
}
