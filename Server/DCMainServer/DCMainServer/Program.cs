using System;
using DC.Net;

namespace DCMainServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainServer = new NetworkServer();
            mainServer.Init("127.0.0.1", 10998);
            mainServer.Start();
        }
    }
}
