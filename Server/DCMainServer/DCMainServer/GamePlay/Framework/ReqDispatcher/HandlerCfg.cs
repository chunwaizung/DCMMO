using System;

namespace DC
{

    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class HandlerCfg : Attribute
    {
        public int mId;

        public HandlerCfg(int id)
        {
            mId = id;
        }
    }

}
