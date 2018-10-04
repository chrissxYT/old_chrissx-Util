using chrissx_Util.Math;
using System.Collections.Generic;
using System.Text;

namespace chrissx_Util.Strings
{
    public static class StringUtil
    {
        /// <summary>
        /// Removes the empty elements in the array.
        /// </summary>
        /// <param name="array">The array to clear</param>
        /// <returns>The cleared array</returns>
        public static T[] RemoveEmpty<T>(this T[] array)
        {
            List<T> Out = new List<T>();

            foreach (T t in array)
                if (t.ToString() != "" && t != null)
                    Out.Add(t);

            return Out.ToArray();
        }

        /// <summary>
        /// Removes the empty elements in the list
        /// </summary>
        /// <param name="list">The list to clear</param>
        /// <returns>The cleared list</returns>
        public static List<T> RemoveEmpty<T>(this List<T> list)
        {
            List<T> Out = new List<T>();

            foreach (T s in list)
                if(s.ToString() != "" && s != null)
                    Out.Add(s);

            return Out;
        }

        /// <summary>
        /// Checks if the string is numeric
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>A bool that determines if the string is numeric</returns>
        public static bool IsNumeric(this string s)
        {
            foreach (char c in s.ToCharArray())
                if(!(c >= 0) && !(c <= 9) && c != ',' && c != '.')
                    return false;

            return true;
        }

        /// <summary>
        /// Sorts the string randomly.
        /// </summary>
        /// <param name="s">The string to sort randomly</param>
        /// <returns>The randomly sorted string</returns>
        public static string SortRandom(this string s)
        {
            StringBuilder sb = new StringBuilder();
            List<int> used = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
                int j = MathUtil.Random.Next(s.Length);
                while (used.Contains(j))
                    j = MathUtil.Random.Next(s.Length);
                used.Add(j);
                sb.Append(s[j]);
            }
            return sb.ToString();
        }

        public static string[] Split(this string s, string seperator)
        {
            return s.Split(seperator.ToCharArray());
        }

        /// <summary>
        /// Wraps the object into a new array.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object to wrap into the array</param>
        /// <returns>A new array which contains the object</returns>
        public static T[] WrapToArray<T>(this T obj)
        {
            return new T[] { obj };
        }

        /// <summary>
        /// Wraps the object into a new list.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object to wrap into the list</param>
        /// <returns>A new list which contains the object</returns>
        public static List<T> WrapToList<T>(this T obj)
        {
            return new List<T> { obj };
        }

        /// <summary>
        /// Appends the second given string to the first given string with a comma and space as a seperator.
        /// </summary>
        /// <param name="s">The string to append to</param>
        /// <param name="stringToAppend">The string to append to the other string</param>
        /// <returns>The new full string</returns>
        public static string AppendWithComma(this string s, string stringToAppend)
        {
            if (s == null || s == "")
                s = stringToAppend;
            else
                s += ", " + stringToAppend;
            return s;
        }

        /// <summary>
        /// Appends one string to the other with a ", " between them if the bool is true
        /// </summary>
        /// <param name="s">The string to append the other one to</param>
        /// <param name="appendToString">The string to append to the other one</param>
        /// <param name="append">A bool to specify if the string should be appended</param>
        /// <returns></returns>
        public static string AppendWithCommaIf(this string s, string appendToString, bool append)
        {
            if (append)
                return s.AppendWithComma(appendToString);
            else
                return s;
        }

        /// <summary>
        /// Converts the chars into their string representation.
        /// </summary>
        /// <param name="chars">The chars for the string</param>
        /// <returns>A new string with all the chars</returns>
        public static string ToString(this char[] chars)
        {
            return new string(chars);
        }

        /// <summary>
        /// Trunicates the string to match the given size.
        /// </summary>
        /// <param name="s">The string to truncate</param>
        /// <param name="max">Its max lenght</param>
        /// <returns>The truncated string</returns>
        public static string Truncate(this string s, int max)
        {
            return s.Length <= max ? s : s.Substring(0, max - 3) + "...";
        }
    }
}
