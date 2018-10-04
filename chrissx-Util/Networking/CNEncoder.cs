using System;
using System.Collections.Generic;
using System.Numerics;

namespace chrissx_Util.Networking
{
    class CNEncoder
    {
        public static string EncodeLine(Dictionary<object, CNDatatype> objects)
        {
            string s = "";
            foreach (KeyValuePair<object, CNDatatype> entry in objects)
            {
                CNDatatype t = entry.Value;
                object o = entry.Key;
                switch (t)
                {
                    case CNDatatype.CHR: s += Char((char)o); break;
                    case CNDatatype.DOU: s += Double((double)o); break;
                    case CNDatatype.FLO: s += Float((float)o); break;
                    case CNDatatype.I32: s += Int32((int)o); break;
                    case CNDatatype.I64: s += Int64((long)o); break;
                    case CNDatatype.IBI: s += BigInt((BigInteger)o); break;
                    case CNDatatype.STR: s += String((String)o); break;
                    default: s += "CRITICAL ERROR IN CNEncoder!!"; break;
                }
            }
            return s;
        }

        public static String String(String s)
        {
            return CNDatatype.STR + "::{" + s + "}::";
        }

        public static String Int32(int i)
        {
            return CNDatatype.I32 + "::{" + i + "}::";
        }

        public static String Int64(long l)
        {
            return CNDatatype.I64 + "::{" + l + "}::";
        }

        public static String BigInt(BigInteger bi)
        {
            return CNDatatype.IBI + "::{" + bi + "}::";
        }

        public static String Float(float f)
        {
            return CNDatatype.FLO + "::{" + f + "}::";
        }

        public static String Double(double d)
        {
            return CNDatatype.DOU + "::{" + d + "}::";
        }

        public static String Char(char c)
        {
            return CNDatatype.CHR + "::{" + c + "}::";
        }
    }
}
