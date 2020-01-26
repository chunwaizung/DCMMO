using System;
using DC;
using DC.Net;

namespace DCMainServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var reqDispatcher = ReqDispatcher.Instance;

            var mainServer = new NetworkServer();
            mainServer.Init("127.0.0.1", 10998);
            mainServer.Start();
        }
    }
}
