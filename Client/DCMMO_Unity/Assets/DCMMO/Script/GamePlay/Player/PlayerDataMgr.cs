using System.Collections.Generic;
using DC.Net;
using Dcgameprotobuf;

namespace DC
{
    public class PlayerDataMgr : Singleton<PlayerDataMgr>
    {
        
        public string UserName;

        public string Password;

        public string UserToken;

        List<RoleInfo> mRoleList = new List<RoleInfo>();

        protected override void OnInit()
        {
            base.OnInit();

        }

        private void OnRoleRes(int id, ProtoPacket protoPkt)
        {
            if (CheckError(id, protoPkt) != ErrorCode.UNIVERSAL)
            {
                return;
            }

            var roleRes = (RoleRes) protoPkt.ProtoObj;

            mRoleList.AddRange(roleRes.Infos);
        }

        public static ErrorCode CheckError(int id, ProtoPacket pkt)
        {
            if (pkt.ProtoObj is ErrorRes errorRes)
            {
                return (ErrorCode) errorRes.No;
            }

            return ErrorCode.UNIVERSAL;
        }

    }

    public enum ProtoErrorType
    {

    }

}