using System.Text;
using UnityEngine;

namespace DC
{
    public static class DCLog
    {
        public static readonly StringBuilder sBd = new StringBuilder();

        public static void Log(string log, params object[] objs)
        {
            Debug.Log(string.Format(log, objs));
        }

        public static void LogEx(params object[] objs)
        {
            sBd.Clear();
            foreach (var o in objs)
            {
                sBd.Append(o).Append(',');
            }

            sBd.Remove(sBd.Length - 1, 1);
            Debug.Log(sBd.ToString());
        }

        public static void Err(string log, params object[] objs)
        {
            Debug.LogError(string.Format(log, objs));
        }

        public static void Waring(string log, params object[] objs)
        {
            Debug.LogWarning(string.Format(log, objs));
        }
    }
}