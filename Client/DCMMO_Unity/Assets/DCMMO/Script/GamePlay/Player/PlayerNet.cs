using System;
using Dcgameprotobuf;

namespace DC
{
    public class PlayerNet : BaseNet<PlayerNet>
    {
        public void ReqRoleList(string userToken, Action<int, ProtoPacket> callback)
        {
            var roleReq = new PRoleReq();
            roleReq.UserToken = userToken;

            SysBoxP.NetworkServiceP.SendAutoRes(roleReq, callback);
        }
    }
}