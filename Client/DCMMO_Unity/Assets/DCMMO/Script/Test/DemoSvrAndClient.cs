﻿using System.Net.Sockets;
using System.Text;
using DC.Net;
using Dcgameprotobuf;
using Google.Protobuf;
using UnityEngine;

namespace DC
{
    public class DemoSvrAndClient : MonoBehaviour
    {
        NetChannel mChannel;

        NetworkServer mServer;

        public string mSendStr = "demo";

        void Awake()
        {
            mServer = new NetworkServer();
            mServer.Init("127.0.0.1", 10998);
            mServer.Start();

            ConnectServer();
        }

        public async void ConnectServer()
        {
            TcpClient client = new TcpClient();
            mChannel = new NetChannel();

            await client.ConnectAsync("127.0.0.1", 10998);
            mChannel.Init(client);
            mChannel.AddListener(OnReceive);
            mChannel.StartReceive();
        }

        public void OnSend()
        {
            var req = new PTestDemoClsReq();
            var reqId = DCGameProtocol.GetId(req);
            var content = req.ToByteArray();

            mChannel.Send(SendBuf.From(DCGameProtocol.GetIntBuf(reqId)), SendBuf.From(content));
//            mChannel.Send(Encoding.UTF8.GetBytes(mSendStr));
        }

        void OnReceive(Packet packet)
        {
            DCLog.LogEx("from server: ", Encoding.UTF8.GetString(packet.Bytes, 0, packet.Length));
        }

        void OnDestroy()
        {
            DCLog.Log("end main");
            mChannel.DisposeRes();
            mChannel.Close();
            mServer.DisposeRes();
            mServer.Close();
        }

    }
}