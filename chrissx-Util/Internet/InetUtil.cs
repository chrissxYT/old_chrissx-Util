using System.Net;
using System.Threading;

namespace chrissx_Util.Internet
{
    public static class InetUtil
    {
        public static void SyncDownloadFile(string url, string file)
        {
            using (WebClient c = new WebClient())
                c.DownloadFile(url, file);
        }

        public static void AsyncDownloadFile(string url, string file)
        {
            new Thread(() => SyncDownloadFile(url, file)).Start();
        }

        public static byte[] DownloadData(string url)
        {
            WebClient c = new WebClient();
            byte[] b = c.DownloadData(url);
            c.Dispose();
            return b;
        }
    }
}
