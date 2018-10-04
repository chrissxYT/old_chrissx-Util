using chrissx_Util.Math;
using System.IO;

namespace chrissx_Util.IO
{
    public static class FileUtil
    {
        public static string TempDir
        {
            get
            {
                string s = Path.GetTempPath() + MathUtil.Random.Next();
                while (File.Exists(s))
                    s = Path.GetTempPath() + MathUtil.Random.Next();
                Directory.CreateDirectory(s);
                return s;
            }
        }

        public static string TempFile
        {
            get
            {
                return Path.GetTempFileName();
            }
        }
    }
}
