using System;
using System.Collections.Concurrent;
using DC.Net;
using UnityEngine;

namespace DC
{
    public class UnityMsgDispatcherTmpl<T> : MonoBehaviour
    {
        protected ConcurrentQueue<T> mMsgQueue = new ConcurrentQueue<T>();

        protected ConcurrentQueue<Action> mActions = new ConcurrentQueue<Action>();

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

        public void PostAction(Action action)
        {
            mActions.Enqueue(action);
        }

        void Update()
        {
            while (!mMsgQueue.IsEmpty)
            {
                if (mMsgQueue.TryDequeue(out var result))
                {
                    mHandler?.Invoke(result);
                }
            }

            while (!mActions.IsEmpty)
            {
                if (mActions.TryDequeue(out var action))
                {
                    action?.Invoke();
                }
            }

        }

    }

    public class UnityMsgDispatcher : UnityMsgDispatcherTmpl<Packet>
    {
        
    }
}