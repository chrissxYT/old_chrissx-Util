using System;
using System.Collections.Generic;
using System.Numerics;

namespace chrissx_Util.Networking
{
    class CNDecoder
    {
        public static Dictionary<object, CNDatatype> DecodeLine(string line)
        {
            Dictionary<object, CNDatatype> Out = new Dictionary<object, CNDatatype>();
            foreach (string s in line.Split(new[] { "}::" }, StringSplitOptions.None))
            {
                CNDatatype adsasd = CNDatatype.CHR;
                CNDatatype t = (CNDatatype)Enum.Parse(adsasd.GetType(), s.Substring(0, 3));
                Object o = new Object();
                switch (t)
                {
                    case CNDatatype.CHR: o = Char(s); break;
                    case CNDatatype.DOU: o = Double(s); break;
                    case CNDatatype.FLO: o = Float(s); break;
                    case CNDatatype.I32: o = Int32(s); break;
                    case CNDatatype.I64: o = Int64(s); break;
                    case CNDatatype.IBI: o = BigInt(s); break;
                    case CNDatatype.STR: o = String(s); break;
                    default: o = "ERROR IN CN"; break;
                }
			    Out.Add(o, t);
            }
            return Out;
        }

        public static string String(string s)
        {
            return s.Replace(CNDatatype.STR + "::{", "");
        }

        public static int Int32(string s)
        {
            return int.Parse(s.Replace(CNDatatype.I32 + "::{", ""));
        }

        public static long Int64(string s)
        {
            return long.Parse(s.Replace(CNDatatype.I64 + "::{", ""));
        }

        public static BigInteger BigInt(string s)
        {
            return BigInteger.Parse(s.Replace(CNDatatype.IBI + "::{", ""));
        }

        public static float Float(string s)
        {
            return float.Parse(s.Replace(CNDatatype.FLO + "::{", ""));
        }

        public static double Double(string s)
        {
            return double.Parse(s.Replace(CNDatatype.DOU + "::{", ""));
        }

        public static char Char(string s)
        {
            return (s.Replace(CNDatatype.FLO + "::{", "")).ToCharArray()[0];
        }
    }
}