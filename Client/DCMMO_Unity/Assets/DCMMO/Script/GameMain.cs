using System.Collections;
using System.Collections.Generic;
using System.Text;
using DC;
using DC.Net;
using UnityEngine;

namespace DCMMO
{
    public class GameMain : MonoBehaviour
    {
        NetworkClient client;

        NetworkServer server;

        public string mSendStr;

        void Awake()
        {
            server = new NetworkServer();
            server.Init("127.0.0.1", 10998);
            server.Start();

            client = new NetworkClient();
            client.Init("127.0.0.1", 10999);
            client.AddListener(OnReceive);
        }

        void OnSend()
        {
            client.Send(Encoding.UTF8.GetBytes(mSendStr));
        }

        void OnReceive(byte[] buf)
        {
            DCLog.LogEx("from server: ",Encoding.UTF8.GetString(buf));
        }
    }
}
