using System;
using System.Collections.Generic;
using System.Net.Sockets;
using DC.Net;
using Dcgameprotobuf;
using Google.Protobuf;

namespace DC
{
    struct ReqRecord
    {
        public int id;
        public float reqTime;
    }

    /// <summary>
    /// 发送Message
    /// 返回ProtoPacket
    /// </summary>
    public class NetworkService : BaseSys
    {
        public float TimeOutDuration = 10;

        Dictionary<int, Delegate> mIdToOnceHandler = new Dictionary<int, Delegate>();

        Dictionary<int, Delegate> mIdToNormalHandler = new Dictionary<int, Delegate>();

        Dictionary<int, ReqRecord> mIdToRecord = new Dictionary<int, ReqRecord>();

        private NetChannel mChannel;

        private UnityMsgDispatcher mUnityMsgDispatcher;

        public void SetUnityMsgDispatcher(UnityMsgDispatcher dispatcher)
        {
            mUnityMsgDispatcher = dispatcher;
            mUnityMsgDispatcher.AddListener(OnReceive);
        }

        //todo add timer to check if req is time out

        public override void Awake()
        {

        }

        private void DisconnectPreviousSvr()
        {

        }

        public async void Connect(ServerConfig svrCfg, Action callback)
        {
            DisconnectPreviousSvr();

            TcpClient client = new TcpClient();
            mChannel = new NetChannel();
            mChannel.AddListener(mUnityMsgDispatcher.OnReceive);

            await client.ConnectAsync(svrCfg.host, svrCfg.port);

            mChannel.Init(client);

            mChannel.StartReceive();
            //todo start heart beat

            callback?.Invoke();
        }

        public void AddHandler(int id, Action<int, ProtoPacket> callback)
        {
            if (mIdToNormalHandler.TryGetValue(id, out var delegateObj))
            {
                delegateObj = Delegate.Remove(delegateObj, callback);
                mIdToNormalHandler[id] = delegateObj;
            }
            else
            {
                mIdToNormalHandler.Add(id, callback);
            }
        }

        public void RmvHandler(int id, Action<int, ProtoPacket> callback)
        {
            RmvFrom(id, callback, mIdToNormalHandler);
        }

        public static void RmvFrom(int id, Action<int, ProtoPacket> callback, Dictionary<int, Delegate> dic)
        {
            if (dic.TryGetValue(id, out var delegateObj))
            {
                delegateObj = Delegate.Remove(delegateObj, callback);
                dic[id] = delegateObj;
            }
        }

        public static void AddToHandler(int id, Action<int, ProtoPacket> callback, Dictionary<int, Delegate> dic)
        {
            if (dic.TryGetValue(id, out var delegateObj))
            {
                delegateObj = Delegate.Combine(delegateObj, callback);
                dic[id] = delegateObj;
            }
            else
            {
                dic.Add(id, callback);
            }
        }

        private void CheckTimeOut()
        {

        }

        private void Send(int reqId, int resId, byte[] content, Action<int, ProtoPacket> callback)
        {
            //todo check network

            if (resId != 0)
            {
                //previous req is override, notify error
                if (mIdToOnceHandler.TryGetValue(resId, out var delegateObj))
                {
                    var error = ProtoPacket.CreateError(resId, (int)ErrorCode.req_override, string.Empty);
                    if (delegateObj != null)
                    {
                        delegateObj.DynamicInvoke(resId, error);
                    }
                    mIdToOnceHandler.Remove(resId);
                }

                if (callback != null)
                {
                    AddToHandler(resId, callback, mIdToOnceHandler);
                }
            }

            mChannel.Send(SendBuf.From(DCGameProtocol.GetIntBuf(reqId)), SendBuf.From(content));
        }

        public void Send(IMessage req, Action<int, ProtoPacket> callback, int resId)
        {
            var id = DCGameProtocol.GetId(req);
            if (id != 0)
            {
                Send(id, resId, req.ToByteArray(), callback);
            }
        }

        public void Send(IMessage req, Action<int, ProtoPacket> callback)
        {
            var id = DCGameProtocol.GetId(req);
            if (id != 0)
            {
                Send(id, 0, req.ToByteArray(), callback);
            }
        }

        public void SendAutoRes(IMessage req, Action<int, ProtoPacket> callback)
        {
            var id = DCGameProtocol.GetId(req);
            if (id != 0)
            {
                Send(id, id + 1, req.ToByteArray(), callback);
            }
        }

        public void OnReceive(Packet packet)
        {
            var protoPacket = ProtoPacket.FromRecvBuf(packet.Bytes, 0, packet.Length);
            var id = protoPacket.protoId;
            DCLog.LogEx("receive protoId ", id);
            if (id > 0)
            {
                //长期监听的先执行
                Invoke(id, protoPacket, mIdToNormalHandler);

                Invoke(id, protoPacket, mIdToOnceHandler);
                mIdToOnceHandler.Remove(id);
            }
        }

        private void Invoke(int id, ProtoPacket packet, Dictionary<int, Delegate> dic)
        {
            if (dic.TryGetValue(id, out var delegateObj))
            {
                if (delegateObj != null)
                {
                    delegateObj.DynamicInvoke(id, packet);
                }
            }
        }

        public void Stop()
        {
            mChannel.Close();
            mChannel.DisposeRes();
        }
    }

}
