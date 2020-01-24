using System;

namespace DC
{
    public class MsgSys
    {
        public static void Send(int evt, params object[] objs)
        {
            MessageSystem.Instance.Send(evt, objs);
        }

        public static void AddDelegate(int type, Delegate action)
        {
            MessageSystem.Instance.AddDelegate(type, action);
        }

        public static void RemoveDelegate(int type, Delegate action)
        {
            MessageSystem.Instance.Remove(type, action);
        }

        public static void Add(int type, Action action)
        {
            AddDelegate(type, action);
        }

        public static void Add<T>(int type, Action<T> action)
        {
            AddDelegate(type, action);
        }

        public static void Add<T1, T2>(int type, Action<T1, T2> action)
        {
            AddDelegate(type, action);
        }

        public static void Add<T1, T2, T3>(int type, Action<T1, T2, T3> action)
        {
            AddDelegate(type, action);
        }

        public static void Add<T1, T2, T3, T4>(int type, Action<T1, T2, T3, T4> action)
        {
            AddDelegate(type, action);
        }

        public static void Add<T1, T2, T3, T4, T5>(int type, Action<T1, T2, T3, T4, T5> action)
        {
            AddDelegate(type, action);
        }

        public static void Remove(int type, Action action)
        {
            RemoveDelegate(type, action);
        }

        public static void Remove<T>(int type, Action<T> action)
        {
            RemoveDelegate(type, action);
        }

        public static void Remove<T1, T2>(int type, Action<T1, T2> action)
        {
            RemoveDelegate(type, action);
        }

        public static void Remove<T1, T2, T3>(int type, Action<T1, T2, T3> action)
        {
            RemoveDelegate(type, action);
        }

        public static void Remove<T1, T2, T3, T4>(int type, Action<T1, T2, T3, T4> action)
        {
            RemoveDelegate(type, action);
        }

        public static void Remove<T1, T2, T3, T4, T5>(int type, Action<T1, T2, T3, T4, T5> action)
        {
            RemoveDelegate(type, action);
        }
    }
}