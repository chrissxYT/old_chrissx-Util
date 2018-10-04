using System;
using System.IO;
using System.Threading;

namespace chrissx_Util.IO
{
    public delegate void MoveStartedEventHandler(object sender, EventArgs args);
    public delegate void MoveFinishedEventHandler(object sender, EventArgs args);

    public delegate void CopyStartedEventHandler(object sender, EventArgs args);
    public delegate void CopyFinishedEventHandler(object sender, EventArgs args);

    public delegate void MoveProgressChangedEventHandler(object sender, ProgressChangedArgs args);
    public delegate void CopyProgressChangedEventHandler(object sender, ProgressChangedArgs args);

    public class FileManager
    {
        public event MoveStartedEventHandler MoveStarted;
        public event MoveFinishedEventHandler MoveFinished;

        public event CopyStartedEventHandler CopyStarted;
        public event CopyFinishedEventHandler CopyFinished;

        public event MoveProgressChangedEventHandler MoveProgressChanged;
        public event CopyProgressChangedEventHandler CopyProgressChanged;

        /// <summary>
        /// The size of the cache used in all operations.
        /// </summary>
        public int CacheSize { get; set; } = 8192;

        public void AsyncMove(string src, string dest)
        {
            new Thread(() => SyncMove(src, dest)).Start();
        }

        public void SyncMove(string src, string dest)
        {
            byte[] buffer = new byte[CacheSize];
            MoveStarted(this, new EventArgs());
            using (FileStream source = new FileStream(src, FileMode.Open, FileAccess.Read))
            {
                long fileLength = source.Length;
                using (FileStream dst = new FileStream(dest, FileMode.CreateNew, FileAccess.Write))
                {
                    long total = 0;
                    int currentBlockSize = 0;
                    byte lastPer = 0;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        total += currentBlockSize;

                        dst.Write(buffer, 0, currentBlockSize);

                        byte per = (byte)((total * 100) / fileLength);
                        if (per > lastPer)
                        {
                            MoveProgressChanged(this, new ProgressChangedArgs(per));
                            lastPer = per;
                        }
                    }
                }
            }
            File.Delete(src);
            MoveFinished(this, new EventArgs());
        }

        public void AsyncCopy(string src, string dest)
        {
            new Thread(() => SyncCopy(src, dest)).Start();
        }

        public void SyncCopy(string src, string dest)
        {
            byte[] buffer = new byte[CacheSize];
            CopyStarted(this, new EventArgs());
            using (FileStream source = new FileStream(src, FileMode.Open, FileAccess.Read))
            {
                long fileLength = source.Length;
                using (FileStream dst = new FileStream(dest, FileMode.CreateNew, FileAccess.Write))
                {
                    long total = 0;
                    int currentBlockSize = 0;
                    byte lastPer = 0;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        total += currentBlockSize;

                        dst.Write(buffer, 0, currentBlockSize);

                        byte per = (byte)((total * 100) / fileLength);
                        if (per > lastPer)
                        {
                            CopyProgressChanged(this, new ProgressChangedArgs(per));
                            lastPer = per;
                        }
                    }
                }
            }
            CopyFinished(this, new EventArgs());
        }
    }
}
