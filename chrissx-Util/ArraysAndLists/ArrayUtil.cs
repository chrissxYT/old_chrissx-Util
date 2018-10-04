namespace chrissx_Util.ArraysAndLists
{
    public static class ArrayUtil
    {
        public static T GetLast<T>(this T[] array)
        {
            return array[array.Length - 1];
        }
    }
}
