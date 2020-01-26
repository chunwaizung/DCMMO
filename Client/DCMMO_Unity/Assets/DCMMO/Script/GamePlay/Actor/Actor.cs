using System.Collections.Generic;

namespace DC
{
    public enum ActorType
    {
        Player,
        Pet,
        Npc,
    }

    public class Actor : GamePlayBehaviour
    {
        List<BaseActorCmpt> mActorCmpts = new List<BaseActorCmpt>();

        
    }

}