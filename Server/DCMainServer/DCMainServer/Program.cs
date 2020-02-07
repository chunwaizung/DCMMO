using System;
using DC;
using DC.Net;

namespace DCMainServer
{
    class Program
    {
        public const string db_path = "D:/projects/unity2019/DCMMO/Server/DB/Demo.db";

        static void Main(string[] args)
        {
            //cfg
            ConfigUtil.CfgFilesRoot =
                "D:\\projects\\unity2019\\DCMMO\\Server\\DCMainServer\\DCMainServer\\DCConfig/cfgbin/";
            
            //db
            var dcdb = DCDB.Instance;
            dcdb.Setup(db_path);

            //logic
            var reqDispatcher = ReqDispatcher.Instance;

            //net
            var mainServer = new NetworkServer();
            mainServer.Init("127.0.0.1", 10998);
            mainServer.Start();

            while (true)
            {
                var line = Console.ReadLine();
                switch (line)
                {
                    case "exit":
                        Exit();
                        return;
                }
            }
        }

        private static void Exit()
        {

        }
    }
}
