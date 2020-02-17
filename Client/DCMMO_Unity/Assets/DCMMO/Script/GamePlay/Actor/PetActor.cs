using Dcgameprotobuf;

namespace DC
{
    public class PetActor : Actor
    {
        public override PActorType GetActorType()
        {
            return PActorType.Pet;
        }
    }
}