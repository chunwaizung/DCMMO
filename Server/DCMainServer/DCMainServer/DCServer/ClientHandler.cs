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
        public NetworkServer Server;

        public string UserToken;

        public string RoleToken;

        private NetChannel mChannel;

        public ClientHandler()
        {
            mChannel = new NetChannel();
        }

        public void SetServer(NetworkServer svr)
        {
            Server = svr;
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
            var id = protoPacket.protoId;
            ReqDispatcher.Instance.Dispatch(this, id, protoPacket);
        }

        private void TestEcho(Packet packet)
        {
            //echo to client
            mChannel.Send(
                SendBuf.From(Encoding.UTF8.GetBytes("echo ")),
                SendBuf.From(packet.Bytes, 0, packet.Length));
        }
    }
}