using System;
using System.Collections.Generic;
using DC.Collections.Generic;

namespace DC
{
    public class SystemManager : Singleton<SystemManager>
    {
        private Dictionary<Type, BaseSys> mTypeToSys = new Dictionary<Type, BaseSys>();

        private List<BaseSys> mSysList = new List<BaseSys>();

        public void AddSys(BaseSys sys)
        {
            if (mTypeToSys.ContainsKey(sys.GetType()))
            {
                DCLog.Err("duplicated sys: " + sys);
                return;
            }

            mTypeToSys.Add(sys.GetType(), sys);
            mSysList.Add(sys);
        }

        public void RemvSys(BaseSys sys)
        {
            if (mTypeToSys.Remove(sys.GetType()))
            {
                mSysList.Remove(sys);
            }
        }

        public T GetSys<T>() where T : BaseSys
        {
            return (T) GetSys(typeof(T));
        }

        public BaseSys GetSys(Type type)
        {
            return mTypeToSys.GetValEx(type);
        }

        public void Awake()
        {
#if UNITY_EDITOR
            //this must be added as first element
            AddSys(new DCLocalServer());
#endif

            var networkService = new NetworkService();
            networkService.ClientMode = true;
            networkService.SetUnityMsgDispatcher(SysBox.Instance.GameMainP.UnityMsgDispatcher);
            
            AddSys(networkService);
            AddSys(new ActorSys());
            AddSys(new LevelSys());

            foreach (var syse in mSysList)
            {
                syse.Awake();
            }
        }

        public void Start()
        {
            foreach (var syse in mSysList)
            {
                syse.Start();
            }
        }

        public void OnEnable()
        {
            foreach (var syse in mSysList)
            {
                syse.OnEnable();
            }
        }

        public void OnApplicationPause()
        {
            foreach (var syse in mSysList)
            {
                syse.OnApplicationPause();
            }
        }

        public void OnApplicationQuit()
        {
            foreach (var syse in mSysList)
            {
                syse.OnApplicationQuit();
            }
        }

        public void OnDisable()
        {
            foreach (var syse in mSysList)
            {
                syse.OnDisable();
            }
        }

        public void OnDestroy()
        {
            foreach (var syse in mSysList)
            {
                syse.OnDestroy();
            }
        }
    }
}