using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace chrissx_Util.IO
{
    public static class DriveUtil
    {
        public static IEnumerable<DriveInfo> Drives
        {
            get
            {
                return DriveInfo.GetDrives().Where(drive => drive.IsReady);
            }
        }
    }
}
