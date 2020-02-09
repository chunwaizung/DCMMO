using UnityEngine;

namespace DC
{
    public class ActorSys : BaseSys
    {
        public Transform mRootTf;

        public override void Awake()
        {
            base.Awake();
            mRootTf = GameObject.Find("ActorRoot").transform;
        }

        public Transform GetRootTf()
        {
            return mRootTf;
        }


    }
}