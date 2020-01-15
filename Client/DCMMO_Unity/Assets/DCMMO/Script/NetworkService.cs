using System;
using System.Collections;
using System.Collections.Generic;
using Dcgameprotobuf;
using Google.Protobuf;
using UnityEngine;

public class NetworkService : MonoBehaviour
{
    Dictionary<int, Action<object>> mIdToHandler = new Dictionary<int, Action<object>>();
    public void Send(int id, byte[] bytes, Action<object> callback)
    {
        mIdToHandler.Add(id, callback);
    }

    public void Send<T>(T req) where T : IMessage<T>
    {

    }

    public void OnReceive(byte[] data)
    {
        int id;
        var res = DCGameProtocol.Parse(data, out id);
        if (id > 0)
        {
            if(mIdToHandler.TryGetValue(id, out var handler))
            {
                handler(res);
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