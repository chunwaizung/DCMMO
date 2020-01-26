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


            //todo start heart beat

            callback?.Invoke();
        }

        public void AddHandler(int id, Action<int, object> callback)
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

        private void Send(int id, byte[] content, Action<int, ProtoPacket> callback)
        {
            //todo check network

            //previous req is override, notify error
            if (mIdToOnceHandler.TryGetValue(id, out var delegateObj))
            {
                var error = ProtoPacket.CreateError(id, (int) ErrorCode.req_override, string.Empty);
                if (delegateObj != null)
                {
                    delegateObj.DynamicInvoke(id, error);
                }
                mIdToOnceHandler.Remove(id);
            }

            if (callback != null)
            {
                AddToHandler(id, callback, mIdToOnceHandler);
            }

            mChannel.Send(SendBuf.From(DCGameProtocol.GetIntBuf(id)), SendBuf.From(content));
        }

        public void Send(IMessage req, Action<int, ProtoPacket> callback)
        {
            var id = DCGameProtocol.GetId(req);
            if (id != 0)
            {
                Send(id, req.ToByteArray(), callback);
            }
        }

        public void OnReceive(Packet packet)
        {
            var protoPacket = ProtoPacket.FromRecvBuf(packet.Bytes, 0, packet.Length);
            var id = protoPacket.protoId;
            if (id > 0)
            {
                Invoke(id, protoPacket, mIdToOnceHandler);
                mIdToOnceHandler.Remove(id);

                Invoke(id, protoPacket, mIdToNormalHandler);
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
    }

}
