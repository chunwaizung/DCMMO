using System;
using System.Collections.Concurrent;
using UnityEngine;

namespace DC
{
    public class UnityMessageDispatcher : MonoBehaviour
    {
        ConcurrentQueue<byte[]> mMsgQueue = new ConcurrentQueue<byte[]>();

        private event Action<byte[]> mHandler;

        public void AddListener(Action<byte[]> onMsg)
        {
            mHandler += onMsg;
        }

        public void RemoveListener(Action<byte[]> onMsg)
        {
            if (null == mHandler) return;

            mHandler -= onMsg;
        }

        public void OnReceive(byte[] msg)
        {
            mMsgQueue.Enqueue(msg);
        }

        void Update()
        {
            while (!mMsgQueue.IsEmpty)
            {
                if (mMsgQueue.TryDequeue(out var result))
                {
                    if (null != mHandler)
                    {
                        mHandler(result);
                    }
                }
            }
        }

    }
}