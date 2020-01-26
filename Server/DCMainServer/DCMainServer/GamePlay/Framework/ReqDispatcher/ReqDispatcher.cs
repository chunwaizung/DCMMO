﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DC.Net;
using DC.Collections.Generic;
using Dcgameprotobuf;

namespace DC
{
    public class ReqDispatcher : Singleton<ReqDispatcher>
    {
        private List<BaseReqHandler> mReqHandlers = new List<BaseReqHandler>();

        public Dictionary<int, Delegate> mIdToDelegates = new Dictionary<int, Delegate>(); 

        protected override void OnInit()
        {
            var types = GetType().Assembly.GetTypes().Where(t=>t.IsClass && t.GetCustomAttributes(typeof(HandlerClsCfg), false).Length > 0);
            foreach (var handlerClsType in types)
            {
                var instance = Activator.CreateInstance(handlerClsType);
                var methodInfos = handlerClsType.GetMethods();
                foreach (var methodInfo in methodInfos)
                {
                    var handlerCfg = methodInfo.GetCustomAttribute<HandlerCfg>();
                    var cfgMId = handlerCfg.mId;
                    var handler = methodInfo.CreateDelegate(typeof(void), instance);
                    mIdToDelegates.Add(cfgMId, handler);
                }
                mReqHandlers.Add((BaseReqHandler) instance);
            }
        }

        public void Dispatch(ClientHandler clientHandler,int id, ProtoPacket packet)
        {
            if (mIdToDelegates.TryGetValue(id, out var handler))
            {
                handler.DynamicInvoke(id, packet);
            }
        }

    }

}