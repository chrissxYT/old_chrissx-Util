using chrissx_Util.Strings;
using System.Collections.Generic;

namespace chrissx_Util.Parsers
{
    public static class Csv
    {
        /// <summary>
        /// Parses CSV to a 2-dimensional string-list
        /// </summary>
        /// <param name="csvLines">The input</param>
        /// <param name="preCut">The pre-cut, for "val1";"val2" use 1</param>
        /// <param name="sufCut">The suf-cut, for "val1";"val2" use 1</param>
        /// <param name="seperator">The seperator between the values, for "val1";"val2" use ";"</param>
        /// <returns>A list of lines</returns>
        public static List<List<string>> ParseCsv(string[] csvLines, byte preCut, byte sufCut, string seperator)
        {
            List<List<string>> Out = new List<List<string>>();
            foreach (string a in csvLines)
            {
                List<string> parsed = new List<string>();
                string ss = a.Substring(preCut, a.Length-sufCut-preCut);
                foreach (string s in StringUtil.RemoveEmpty(ss.Split(seperator.ToCharArray())))
                    parsed.Add(s);
                Out.Add(parsed);
            }
            return Out;
        }

        /// <summary>
        /// Parses CSV to a 2-dimenstional string-list
        /// </summary>
        /// <param name="csvLines">The input</param>
        /// <param name="seperator">The seperator between the values</param>
        /// <returns>A list of lines</returns>
        public static List<List<string>> ParseCsv(string[] csvLines, string seperator)
        {
            List<List<string>> Out = new List<List<string>>();
            foreach (string a in csvLines)
            {
                List<string> parsed = new List<string>();
                foreach (string s in StringUtil.RemoveEmpty(a.Split(seperator.ToCharArray())))
                    parsed.Add(s);
                Out.Add(parsed);
            }
            return Out;
        }
    }
}
