using System;
using DC;
using DC.Net;

namespace DCMainServer
{
    class Program
    {
        public const string db_path = "Demo.db";

        static void Main(string[] args)
        {
            var dcdb = DCDB.Instance;
            dcdb.Setup(db_path);

            var reqDispatcher = ReqDispatcher.Instance;

            var mainServer = new NetworkServer();
            mainServer.Init("127.0.0.1", 10998);
            mainServer.Start();
        }
    }
}
