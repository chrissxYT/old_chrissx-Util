using System;
using System.Collections.Generic;
using System.Text;

namespace chrissx_Util.Conversion
{
    public static class Converter
    {
        /// <summary>
        /// Converts the given array to a list.
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="array">The array</param>
        /// <returns>A list with all the elements of the array</returns>
        public static List<T> ToList<T>(this T[] array)
        {
            return new List<T>(array);
        }
        

        public static string ToBase64(this byte[] b)
        {
            return Convert.ToBase64String(b);
        }

        public static byte[] ToByteArray(this string base64)
        {
            return Convert.FromBase64String(base64);
        }

        public static string ToBase64(this string s)
        {
            return Encoding.UTF8.GetBytes(s).ToBase64();
        }

        public static string ToDecodedString(this string base64)
        {
            return Encoding.UTF8.GetString(base64.ToByteArray());
        }

        /// <summary>
        /// Converts the given int into a byte[].
        /// </summary>
        /// <param name="i">The int to convert</param>
        /// <returns>The int as a byte[]</returns>
        public static byte[] GetBytes(this int i)
        {
            return BitConverter.GetBytes(i);
        }

        public static byte[] GetBytes(this long l)
        {
            return BitConverter.GetBytes(l);
        }

        public static byte[] GetBytes(this short s)
        {
            return BitConverter.GetBytes(s);
        }

        public static byte[] GetBytes(this uint i)
        {
            return BitConverter.GetBytes(i);
        }

        public static byte[] GetBytes(this ulong l)
        {
            return BitConverter.GetBytes(l);
        }

        public static byte[] GetBytes(this ushort s)
        {
            return BitConverter.GetBytes(s);
        }

        public static byte[] GetBytes(this bool b)
        {
            return BitConverter.GetBytes(b);
        }

        public static byte[] GetBytes(this char c)
        {
            return BitConverter.GetBytes(c);
        }

        public static byte[] GetBytes(this double d)
        {
            return BitConverter.GetBytes(d);
        }

        public static byte[] GetBytes(this float f)
        {
            return BitConverter.GetBytes(f);
        }
        

        public static int ToInt(this byte[] b)
        {
            return BitConverter.ToInt32(b, 0);
        }

        public static long ToLong(this byte[] b)
        {
            return BitConverter.ToInt64(b, 0);
        }

        public static bool ToBool(this byte[] b)
        {
            return BitConverter.ToBoolean(b, 0);
        }

        public static short ToShort(this byte[] b)
        {
            return BitConverter.ToInt16(b, 0);
        }

        public static uint ToUInt(this byte[] b)
        {
            return BitConverter.ToUInt32(b, 0);
        }

        public static ulong ToULong(this byte[] b)
        {
            return BitConverter.ToUInt64(b, 0);
        }

        public static ushort ToUShort(this byte[] b)
        {
            return BitConverter.ToUInt16(b, 0);
        }

        public static char ToChar(this byte[] b)
        {
            return BitConverter.ToChar(b, 0);
        }

        public static double ToDouble(this byte[] b)
        {
            return BitConverter.ToDouble(b, 0);
        }

        public static float ToFloat(this byte[] b)
        {
            return BitConverter.ToSingle(b, 0);
        }
    }
}
