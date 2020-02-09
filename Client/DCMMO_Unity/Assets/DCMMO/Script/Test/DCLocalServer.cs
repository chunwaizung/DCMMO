using System;
using System.Collections;
using System.Collections.Generic;
using Dcgameprotobuf;
using UnityEngine;

namespace DC
{
    /// <summary>
    /// 本地虚拟服务器
    /// </summary>
    public class DCLocalServer : BaseSys
    {
        public DCLocalServer Instance => SystemManager.Instance.GetSys<DCLocalServer>();

        private Queue<ClientReq> mReqQueue = new Queue<ClientReq>();

        public void Handle(int id, byte[] content, Action<int, ProtoPacket> callback)
        {
            switch (id)
            {
                case DCProtocolIds.PRoleReq:
                    break;
                case DCProtocolIds.PLoginSvrReq:
                    break;
            }
        }
    }

    struct ClientReq
    {
        public int id;
        public byte[] content;
        public Action<int, ProtoPacket> callback;
    }
}