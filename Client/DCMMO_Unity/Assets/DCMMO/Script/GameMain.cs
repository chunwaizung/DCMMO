using UnityEngine;
using UnityEngine.SceneManagement;

namespace DC
{
    public class GameMain : UnityGamePlayBehaviour
    {
        private static GameMain _Instance;

        public static GameMain Instance => _Instance;

        private SystemManager mSysManager;

        public UnityMsgDispatcher UnityMsgDispatcher { get; private set; }

        public GameObject[] NotDestroy;

        void Awake()
        {
            _Instance = this;

            //init
            var dcTimer = DCTimer.Instance;

            UnityMsgDispatcher = gameObject.AddComponent<UnityMsgDispatcher>();

            mSysManager = SystemManager.Instance;

            foreach (var gobj in NotDestroy)
            {
                DontDestroyOnLoad(gobj);
            }

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

        void OnSvrData()
        {
            MsgSys.Send(SysEvt.get_svr_list_suc);
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
