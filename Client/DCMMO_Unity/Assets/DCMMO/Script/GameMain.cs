using System.Net.Sockets;
using System.Text;
using DC;
using DC.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DCMMO
{
    public class GameMain : GamePlayBehaviour
    {
        private SystemManager mSysManager;

        void Awake()
        {
            mSysManager = new SystemManager();

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
        }

    }

}
