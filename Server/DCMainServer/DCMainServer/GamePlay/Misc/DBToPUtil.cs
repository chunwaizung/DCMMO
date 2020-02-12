using DC.Model;
using Dcgameprotobuf;

namespace DC
{
    public class DBToPUtil
    {
        public static PActorData DRoleDataToP(DBRoleData dbData)
        {
            return new PActorData
            {
                ActorMp = dbData.mp,
                ActorHp = dbData.hp,
            };
        }
    }
}