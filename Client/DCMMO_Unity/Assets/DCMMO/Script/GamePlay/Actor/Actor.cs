using System.Collections.Generic;

namespace DC
{
    public enum ActorType
    {
        Player = 1,
        Pet,
        Npc,
    }

    public class Actor : GamePlayBehaviour
    {
        List<BaseActorCmpt> mActorCmpts = new List<BaseActorCmpt>();

        
    }

}