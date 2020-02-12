using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SQLite;

namespace DC
{
    public class BaseDB<T> where T : BaseDB<T>, new()
    {
        private static T sInstance;

        private static readonly object sLock = new object();

        public static T Instance
        {
            get
            {
                lock (sLock)
                {
                    if (sInstance == null)
                    {
                        sInstance = new T();
                        sInstance.OnInit();
                    }
                }

                return sInstance;
            }
        }

        protected virtual void OnInit()
        {

        }

        protected SQLiteConnection Con => DCDB.Instance.GetCon();

        public T GetSingle<T>(Expression<Func<T, bool>> func) where T : new()
        {
            var q = Con.Table<T>().Where(func);

            if (q.Any()) return q.First();

            return default;
        }

        public List<T> GetList<T>(Expression<Func<T, bool>> func) where T :new()
        {
            var q = Con.Table<T>().Where(func);
            return q.ToList();
        }

        public void Save<T>(T obj) where T : new()
        {
            Con.Insert(obj);
        }
    }
}