using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DC.Net;
using DC.Collections.Generic;
using Dcgameprotobuf;

namespace DC
{
    public delegate void ReqHandler(ClientHandler clientHandler, int id, ProtoPacket packet);

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
                if (instance is BaseReqHandler baseReqHandler)
                {
                    baseReqHandler.OnInit();
                }

                var methodInfos = handlerClsType.GetMethods();
                foreach (var methodInfo in methodInfos)
                {
                    var handlerCfg = methodInfo.GetCustomAttribute<HandlerCfg>();
                    if (handlerCfg == null)
                    {
                        continue;
                    }

                    var cfgMId = handlerCfg.mId;
                    var handler = methodInfo.CreateDelegate(typeof(ReqHandler), instance);
                    mIdToDelegates.Add(cfgMId, handler);
                }
                mReqHandlers.Add((BaseReqHandler) instance);
            }
        }

        public void Dispatch(ClientHandler clientHandler,int id, ProtoPacket packet)
        {
            DCLog.LogEx("handle req ", id);
            if (mIdToDelegates.TryGetValue(id, out var handler))
            {
                handler.DynamicInvoke(clientHandler, id, packet);
            }
        }

    }

}