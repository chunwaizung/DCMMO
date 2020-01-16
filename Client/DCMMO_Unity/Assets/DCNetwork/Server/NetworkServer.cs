using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Dcgameprotobuf;

namespace DC.Net
{
    public class NetworkServer : CRes
    {
        private TcpListener mTcpListener;

        public void Init(string host, int port)
        {
            mTcpListener = new TcpListener(IPAddress.Parse(host), port);
            mTcpListener.Start();
        }

        public async void Start()
        {
            while (true)
            {
                if (mDisposed)
                {
                    return;
                }

                var tcpClient = await mTcpListener.AcceptTcpClientAsync();
                new ClientHandler().Handle(tcpClient);
            }
        }

    }

    public class ClientHandler
    {
        private CircularBuffer mRecvBuf = new CircularBuffer();

        private PacketParser mPacketParser;

        public ClientHandler()
        {
            mPacketParser = new PacketParser(mRecvBuf);
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
                }

                cnt = await mRecvBuf.WriteAsync(stream);
            }
        }

        public void OnMsg(byte[] buf)
        {
            var protoId = DCGameProtocol.GetProtoId(buf);
        }
    }
}