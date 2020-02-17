using Dcgameprotobuf;

namespace DC
{
    public class PlayerActor : Actor
    {
        private PPlayerActorInfo mActorInfo;
        
        public void Init(PPlayerActorInfo actorInfo)
        {
            mActorInfo = actorInfo;
        }

        public override PActorType GetActorType()
        {
            return PActorType.Player;
        }
    }
}