using UnityEngine.SceneManagement;

namespace DC
{
    public class GameMain : GamePlayBehaviour
    {
        private static GameMain _Instance;

        public static GameMain Instance => _Instance;

        private SystemManager mSysManager;

        private UnityMsgDispatcher mUnityMsgDispatcher;

        public UnityMsgDispatcher UnityMsgDispatcher => mUnityMsgDispatcher;

        void Awake()
        {
            _Instance = this;

            mUnityMsgDispatcher = gameObject.AddComponent<UnityMsgDispatcher>();

            var dcTimer = DCTimer.Instance;

            mSysManager = SystemManager.Instance;

            mUnityMsgDispatcher = new UnityMsgDispatcher();

            mSysManager.Awake();
        }

        public void OnEnable()
        {
            mSysManager.OnEnable();
        }

        public void Start()
        {
            mSysManager.Start();

            var id = 100001;
            var mapCfg = MapCfgMgr.Instance.GetMapConfigByID(id);
            if (null != mapCfg)
            {
                SceneManager.LoadScene(System.IO.Path.GetFileNameWithoutExtension(mapCfg.AssetPath), LoadSceneMode.Additive);
            }
            else
            {
                DCLog.Err("can not load level with id : {0}", id);
            }

            DCCoroutine.Instance.StartCoroutine(GameServerDataMgr.Instance.ReqSvrData(OnSvrData));
        }

        void OnSvrData()
        {
            MsgSys.Send(GEvt.get_svr_list_suc);
        }

        public void OnApplicationPause()
        {
            mSysManager.OnApplicationPause();
        }

        public void OnApplicationQuit()
        {
            mSysManager.OnApplicationQuit();
        }

        public void OnDisable()
        {
            mSysManager.OnDisable();
        }

        public void OnDestroy()
        {
            mSysManager.OnDestroy();

            _Instance = null;
        }

    }

}
