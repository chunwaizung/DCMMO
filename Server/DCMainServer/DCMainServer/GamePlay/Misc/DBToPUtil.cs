using DC.Model;
using Dcgameprotobuf;

namespace DC
{
    public class DBToPUtil
    {
        public static PActorData DRoleDataToP(DBRoleData dbData)
        {
            var pdata = new PActorData();

            if (null == dbData) return pdata;

            pdata.Hp = dbData.hp;
            pdata.Mp = dbData.mp;

            return pdata;
        }
    }
}