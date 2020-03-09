using System.Collections.Generic;
using Dcgameprotobuf;

namespace DC
{
    public enum ActorType
    {
        Player = 1,
        Pet,
        Npc,
    }

    public abstract class Actor : GamePlayBehaviour
    {
        List<BaseActorCmpt> mActorCmpts = new List<BaseActorCmpt>();

        public abstract PActorType GetActorType();

        public virtual int GetActorGId()
        {
            return 0;
        }
    }

}