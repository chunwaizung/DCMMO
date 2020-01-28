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
    }
}