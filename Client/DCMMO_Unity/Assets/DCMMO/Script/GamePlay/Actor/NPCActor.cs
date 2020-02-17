using Dcgameprotobuf;

namespace DC
{
    public class NpcActor : Actor
    {
        public override PActorType GetActorType()
        {
            return PActorType.Npc;
        }
    }
}