using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace DC
{
    /// <summary>
    /// get server list with http request
    /// </summary>
    public class GameServerDataMgr : Singleton<GameServerDataMgr>
    {
        List<ServerConfig> mServerConfigs = new List<ServerConfig>();

        protected override void OnInit()
        {
            
        }

        public ServerConfig GetLastLoginSvr()
        {
            return mServerConfigs[0];
        }

        public IEnumerator ReqSvrData(Action callback)
        {
            if (Application.isEditor)
            {
                mServerConfigs.Add(new ServerConfig()
                {
                    host = "127.0.0.1",
                    port = 10998,
                    newSvr = 1,
                    state = (int)SvrState.low_load
                });
            }
            else
            {
                var webRequest = UnityWebRequest.Get("");
                yield return webRequest.SendWebRequest();

                if (webRequest.isNetworkError)
                {

                }

                if (webRequest.isHttpError)
                {

                }
            }

            callback?.Invoke();
        }
    }

    public enum SvrState
    {
        low_load,
        normal_load,
        high_load,
    }

    public class ServerConfig
    {
        public string host;
        public int port;
        public int newSvr;
        public int state;
    }
}