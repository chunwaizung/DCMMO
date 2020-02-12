using System;
using System.Net.Sockets;
using System.Text;
using DC.Model;
using Dcgameprotobuf;
using Google.Protobuf;

namespace DC.Net
{
    /// <summary>
    /// 处理与客户端的协议交互
    /// </summary>
    public class ClientHandler
    {
        public NetworkServer Server;

        public DBUser User;

        public DBRole Role;

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

        private void Send(int id, byte[] content)
        {
            mChannel.Send(SendBuf.From(DCGameProtocol.GetIntBuf(id)), SendBuf.From(content));
        }

        public void Send(IMessage ms)
        {
            var id = DCGameProtocol.GetId(ms);
            if (id != 0)
            {
                Send(id, ms.ToByteArray());
            }
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