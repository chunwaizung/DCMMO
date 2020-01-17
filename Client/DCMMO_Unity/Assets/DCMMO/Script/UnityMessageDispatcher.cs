using System;
using System.Collections.Concurrent;
using DC.Net;
using UnityEngine;

namespace DC
{
    public class UnityMsgDispatcherTmpl<T> : MonoBehaviour
    {
        protected ConcurrentQueue<T> mMsgQueue = new ConcurrentQueue<T>();

        protected event Action<T> mHandler;

        public void AddListener(Action<T> onMsg)
        {
            mHandler += onMsg;
        }

        public void RemoveListener(Action<T> onMsg)
        {
            if (null == mHandler) return;

            mHandler -= onMsg;
        }

        public void OnReceive(T msg)
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

    public class UnityMessageDispatcher : UnityMsgDispatcherTmpl<Packet>
    {
        

    }
}