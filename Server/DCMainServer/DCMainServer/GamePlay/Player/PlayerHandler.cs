using DC.Net;
using Dcgameprotobuf;

namespace DC
{
    [HandlerClsCfg]
    public class PlayerHandler : BaseReqHandler
    {

        [HandlerCfg(DCProtocolIds.RoleReq)]
        public void HandleRoleReq(ClientHandler clientHandler,int id, ProtoPacket packet)
        {

        }
    }
}