using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Dcgameprotobuf;

namespace DC.Net
{
    /// <summary>
    /// 接收客户端
    /// 开启多线程处理客户端
    /// </summary>
    public class NetworkServer : ManualRes
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
                var clientHandler = new ClientHandler();
                clientHandler.SetServer(this);
                clientHandler.Handle(tcpClient);
            }
        }

    }
    
}