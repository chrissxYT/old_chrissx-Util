using System.Collections.Generic;

namespace chrissx_Util.ArraysAndLists
{
    public static class ListUtil
    {
        public static T GetLast<T>(this List<T> list)
        {
            return list[list.Count - 1];
        }
    }
}
