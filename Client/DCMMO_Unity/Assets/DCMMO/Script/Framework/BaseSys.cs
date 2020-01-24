namespace DC
{
    public abstract class BaseSys
    {
        public SysBox SysBoxP => SysBox.Instance;

        public virtual void Awake()
        {
        }

        public virtual void OnEnable()
        {

        }

        public virtual void Start()
        {

        }

        public virtual void OnApplicationPause()
        {

        }

        public virtual void OnApplicationQuit()
        {

        }

        public virtual void OnDisable()
        {

        }

        public virtual void OnDestroy()
        {

        }
    }
}