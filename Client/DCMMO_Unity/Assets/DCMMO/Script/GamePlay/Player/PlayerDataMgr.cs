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

        public RoleInfo CurRole;

        protected override void OnInit()
        {
            base.OnInit();

            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.RoleRes, OnRoleRes);
            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.AddRoleRes, OnAddRoleRes);
            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.LoginSvrRes, OnLoginSvrRes);
        }

        void OnLoginSvrRes(int id, ProtoPacket proto)
        {
            
        }

        void OnAddRoleRes(int id, ProtoPacket proto)
        {
            var roleInfo = (RoleInfo) proto.ProtoObj;
            mRoleList.Add(roleInfo);
        }

        private void OnRoleRes(int id, ProtoPacket protoPkt)
        {
            if (DCGameProtocol.CheckError(id, protoPkt) != ErrorCode.UNIVERSAL)
            {
                var errorRes = protoPkt.GetError();
                DCLog.LogEx(errorRes.No, errorRes.OpCode, errorRes.Msg);
                return;
            }

            var roleRes = (RoleRes) protoPkt.ProtoObj;
            mRoleList.Clear();
            mRoleList.AddRange(roleRes.Infos);
        }

        public List<RoleInfo> GetRoleList()
        {
            return mRoleList;
        }
    }

    public enum ProtoErrorType
    {

    }

}