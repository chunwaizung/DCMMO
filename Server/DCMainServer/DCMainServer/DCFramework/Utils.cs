using System.Collections.Generic;

namespace DC
{
    public class Utils
    {
        public static bool IsNullOrEmpty<T>(T[] array)
        {
            return array == null || array.Length == 0;
        }

        public static bool IsNullOrEmpty<T>(List<T> list)
        {
            return list == null || list.Count == 0;
        }
    }
}