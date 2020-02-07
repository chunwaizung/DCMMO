using System;
using System.Collections.Generic;

namespace DC.UI
{
    public class BaseUI : MonoGamePlayBehaviour
    {
        List<int> mTypes = new List<int>();

        List<Delegate> mDelegates = new List<Delegate>();

//        public GameObject gameObject;

        protected void AddSmartListener(int type, Action action)
        {
            AddSmartListenerD(type, action);
        }

        protected void AddSmartListener<T>(int type, Action<T> action)
        {
            AddSmartListenerD(type, action);
        }

        protected void AddSmartListener<T1, T2>(int type, Action<T1, T2> action)
        {
            AddSmartListenerD(type, action);
        }

        protected void AddSmartListener<T1, T2, T3>(int type, Action<T1, T2, T3> action)
        {
            AddSmartListenerD(type, action);
        }

        protected void AddSmartListener<T1, T2, T3, T4>(int type, Action<T1, T2, T3, T4> action)
        {
            AddSmartListenerD(type, action);
        }

        protected void AddSmartListener<T1, T2, T3, T4,T5>(int type, Action<T1, T2, T3, T4,T5> action)
        {
            AddSmartListenerD(type, action);
        }

        protected void AddSmartListenerD(int type, Delegate listener)
        {
            mTypes.Add(type);
            mDelegates.Add(listener);

            MsgSys.AddDelegate(type, listener);
        }

        public virtual void Init(params object[] param)
        {

        }

        public virtual void UpdateUi(params object[] param)
        {

        }

        public virtual void OnShow()
        {

        }

        public virtual void OnHide()
        {

        }

        public virtual void OnWindowDestroy()
        {
            for (var i = 0; i < mTypes.Count; i++)
            {
                var t = mTypes[i];
                var d = mDelegates[i];
                MsgSys.RemoveDelegate(t,d);
            }
            mTypes.Clear();
            mDelegates.Clear();
        }

        public virtual void Close()
        {
            UiSys.CloseUi(UISys.GetUiName(GetType()));
        }

        public UISys UiSys
        {
            get { return SysBoxP.UiSysP; }
        }
    }
}