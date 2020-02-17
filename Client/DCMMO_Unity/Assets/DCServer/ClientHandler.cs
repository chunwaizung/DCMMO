using System;
using System.Net.Sockets;
using System.Text;
using Dcgameprotobuf;

namespace DC.Net
{
    /// <summary>
    /// 处理与客户端的协议交互
    /// </summary>
    public class ClientHandler
    {
        private NetworkServer mServer;

        private string mUserToken;

        private string mRoleToken;

        private NetChannel mChannel;

        public ClientHandler()
        {
            mChannel = new NetChannel();
        }

        public void SetServer(NetworkServer svr)
        {
            mServer = svr;
        }

        public void Handle(TcpClient client)
        {
            DCLog.Log("connect a client ...");
            mChannel.Init(client);
            mChannel.AddListener(OnMsg);

            mChannel.StartReceive();
        }

        public void OnMsg(Packet packet)
        {
            //首次连接第一个协议必须是user token

            var protoPacket = ProtoPacket.FromRecvBuf(packet.Bytes, 0, packet.Length);
            if (protoPacket.ProtoObj is PTestDemoClsReq req)
            {
                var f1 = req.F1;
                if (f1 == null)
                {
                    DCLog.Log("default is null");
                }
            }

            //echo to client
            mChannel.Send(
                SendBuf.From(Encoding.UTF8.GetBytes("echo ")),
                SendBuf.From(packet.Bytes,0,packet.Length));

        }
    }
}