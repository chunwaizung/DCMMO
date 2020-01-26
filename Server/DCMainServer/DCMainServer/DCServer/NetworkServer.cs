using System.Net;
using System.Net.Sockets;

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
            DCLog.Log("server start ....");

            mTcpListener = new TcpListener(IPAddress.Parse(host), port);
            mTcpListener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            mTcpListener.Server.NoDelay = true;
            mTcpListener.Start();
        }

        public async void Start()
        {
            DCLog.Log("server start accept ....");

            while (true)
            {
                if (mDisposed)
                {
                    return;
                }

                var tcpClient = await mTcpListener.AcceptTcpClientAsync();
                var clientHandler = new ClientHandler();
                clientHandler.Server = this;
                clientHandler.Handle(tcpClient);
            }
        }

        public void Close()
        {
            mTcpListener.Stop();
        }

    }
    
}