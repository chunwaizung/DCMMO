namespace DC
{
    public class BaseNet<T> where T : BaseNet<T>, new()
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

        public SysBox SysBoxP => SysBox.Instance;

    }
}