using System;
using System.Net.Sockets;
using Dcgameprotobuf;

namespace DC.Net
{
    /// <summary>
    /// 处理与客户端的协议交互
    /// </summary>
    public class ClientHandler
    {
        private CircularBuffer mRecvBuf = new CircularBuffer();

        private PacketParser mPacketParser;

        private NetworkServer mServer;

        private string mUserToken;

        private string mRoleToken;

        public ClientHandler()
        {
            mPacketParser = new PacketParser(mRecvBuf);
        }

        public void SetServer(NetworkServer svr)
        {
            mServer = svr;
        }

        public async void Handle(TcpClient client)
        {
            var stream = client.GetStream();
            var cnt = await mRecvBuf.WriteAsync(stream);
            while (cnt > 0)
            {
                var suc = mPacketParser.Parse();
                if (suc)
                {
                    var packet = mPacketParser.GetPacket();
                    var realBuf = new byte[packet.Length];
                    Array.Copy(packet.Bytes, 0, realBuf, 0, realBuf.Length);
                    //len + protoId + body
                    var protoPacket = ProtoPacket.FromRecvBuf(realBuf);
                    if (DCProtocolIds.RoleReq == protoPacket.protoId)
                    {

                    }
                }

                cnt = await mRecvBuf.WriteAsync(stream);
            }
        }

        public void OnMsg(byte[] buf)
        {
            var protoId = DCGameProtocol.GetInt(buf);
        }
    }
}