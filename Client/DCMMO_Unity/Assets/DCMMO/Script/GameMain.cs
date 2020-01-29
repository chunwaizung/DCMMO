using UnityEngine.SceneManagement;

namespace DC
{
    public class GameMain : UnityGamePlayBehaviour
    {
        private static GameMain _Instance;

        public static GameMain Instance => _Instance;

        private SystemManager mSysManager;

        public UnityMsgDispatcher UnityMsgDispatcher { get; private set; }

        void Awake()
        {
            _Instance = this;

            //init
            var dcTimer = DCTimer.Instance;

            UnityMsgDispatcher = gameObject.AddComponent<UnityMsgDispatcher>();

            mSysManager = SystemManager.Instance;

            mSysManager.Awake();
        }

        public void OnEnable()
        {
            mSysManager.OnEnable();
        }

        public void Start()
        {
            mSysManager.Start();

            mSysManager.GetSys<UISys>().ShowUi<LoginUI>();

            DCCoroutine.Instance.StartCoroutine(GameServerDataMgr.Instance.ReqSvrData(OnSvrData));
        }

        private void TestLoadLevel()
        {
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
