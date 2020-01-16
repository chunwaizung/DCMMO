using System;
using System.Collections;
using System.Collections.Generic;
using DC.Net;
using Dcgameprotobuf;
using Google.Protobuf;
using UnityEngine;

namespace DC
{
    /*
     packet len + protoId + body
     */

    public class NetworkService
    {
        Dictionary<int, List<Action<int, object>>> mIdToOnceHandler = new Dictionary<int, List<Action<int, object>>>();

        Dictionary<int, List<Action<int, object>>>
            mIdToNormalHandler = new Dictionary<int, List<Action<int, object>>>();

        private NetworkClient mClient;

        private UnityMessageDispatcher mUnityMsgDispatcher;

        public void Init()
        {
            mUnityMsgDispatcher.AddListener(OnReceive);
            mClient.AddListener(mUnityMsgDispatcher.OnReceive);
        }

        public void Send(int id, byte[] bytes, Action<int, object> callback)
        {
            if (callback != null)
            {
                AddToHandler(id, callback, mIdToOnceHandler);
            }

            mClient.Send(bytes);
        }

        public void AddHandler(int id, Action<int, object> callback)
        {
            AddToHandler(id, callback, mIdToNormalHandler);
        }

        public static void AddToHandler(int id, Action<int, object> handler,
            Dictionary<int, List<Action<int, object>>> dic)
        {
            if (!dic.TryGetValue(id, out var list))
            {
                list = new List<Action<int, object>>();
                dic.Add(id, list);
            }

            list.Add(handler);
        }

        public void Send<T>(T req, Action<int, object> callback) where T : IMessage<T>
        {
            var id = DCGameProtocol.GetId(req);
            if (id != 0)
            {
                Send(id, DCGameProtocol.Convert(id, req), callback);
            }
        }

        public void Send<T>(T req) where T : IMessage<T>
        {
            Send(req, null);
        }

        public void OnReceive(byte[] data)
        {
            int id;
            var res = DCGameProtocol.Parse(data, out id);
            if (id > 0)
            {
                Invoke(id, res, mIdToOnceHandler);
                mIdToOnceHandler.Remove(id);

                Invoke(id, res, mIdToNormalHandler);
            }
        }

        private void Invoke(int id, object res, Dictionary<int, List<Action<int, object>>> dic)
        {
            if (dic.TryGetValue(id, out var handlers))
            {
                var handlersCount = handlers.Count;
                for (int i = 0; i < handlersCount; i++)
                {
                    var handler = handlers[i];
                    if (null != handler)
                    {
                        handler(id, res);
                    }
                }
            }
        }
    }

    public class NetworkReqResTest
    {
        private NetworkService mNetworkService;

        public void ReqRole(string token)
        {
            var req = new RoleReq();
            req.Token = token;
            mNetworkService.Send(req);
        }
    }
}