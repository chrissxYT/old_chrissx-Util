using System;

namespace chrissx_Util.IO
{
    public class ProgressChangedArgs : EventArgs
    {
        public byte Progress { get; private set; } = 101;

        public ProgressChangedArgs(byte progress)
        {
            Progress = progress;
        }
    }
}
