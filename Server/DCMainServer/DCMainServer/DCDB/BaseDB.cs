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

        public M GetSingle<M>(Expression<Func<M, bool>> func) where M : new()
        {
            var q = Con.Table<M>().Where(func);

            if (q.Any()) return q.First();

            return default;
        }

        public List<M> GetList<M>(Expression<Func<M, bool>> func) where M : new()
        {
            var q = Con.Table<M>().Where(func);
            return q.ToList();
        }

        public void Save<M>(M obj) where M : new()
        {
            Con.Insert(obj);
        }
    }
}