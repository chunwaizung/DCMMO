using System.Collections.Generic;
using DC.Collections.Generic;
using Dcgameprotobuf;
using UnityEngine;

namespace DC
{
    public class ActorSys : BaseSys
    {
        private Transform mRootTf;

        private Dictionary<int, Actor> mIdToActor = new Dictionary<int, Actor>();

        public override void Awake()
        {
            base.Awake();
            var actorRoot = GameObject.Find("ActorRoot");
            if (null == actorRoot)
            {
                actorRoot = new GameObject("ActorRoot");
                Object.DontDestroyOnLoad(actorRoot);
            }
            mRootTf = actorRoot.transform;
        }

        public Transform GetRootTf()
        {
            return mRootTf;
        }

        public void Add(int id, Actor actor)
        {
            mIdToActor[id] = actor;
        }

        public bool Remove(int id)
        {
            return mIdToActor.Remove(id);
        }

        public void Update(int id, Actor actor)
        {
            Add(id, actor);
        }

        public Actor Get(int id)
        {
            return mIdToActor.GetValEx(id);
        }

        /*

            switch (actorInfo.ActorType)
            {
                case PActorType.Player:

                    break;
                case PActorType.Npc:
                    break;
                case PActorType.Pet:
                    break;
            }*/

        public PlayerActor CreateActor(PPlayerActorInfo actorInfo)
        {
            /*
             load actor prefab res
             */
            return null;
        }

        public PlayerActor CreateActor(PPetActorInfo actorInfo)
        {

            return null;
        }

        public PlayerActor CreateActor(PNpcActorInfo actorInfo)
        {

            return null;
        }


    }
}