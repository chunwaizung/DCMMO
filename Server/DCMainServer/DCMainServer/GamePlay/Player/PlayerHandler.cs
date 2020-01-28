using DC.Model;
using DC.Net;
using Dcgameprotobuf;

namespace DC
{
    [HandlerClsCfg]
    public class PlayerHandler : BaseReqHandler
    {
        [HandlerCfg(DCProtocolIds.AddRoleReq)]
        public void HandleAddRoleReq(ClientHandler clientHandler, int id, ProtoPacket packet)
        {
            var roleReq = (AddRoleReq)packet.ProtoObj;
            var role = PlayerDB.Instance.CreateRole(clientHandler.User.ID, (int) roleReq.Job);
            clientHandler.Role = role;
            var addRoleRes = new AddRoleRes();
            clientHandler.Send(addRoleRes);
        }

        [HandlerCfg(DCProtocolIds.RoleReq)]
        public void HandleRoleReq(ClientHandler clientHandler,int id, ProtoPacket packet)
        {
            var roleReq = (RoleReq) packet.ProtoObj;
            clientHandler.User = PlayerDB.Instance.GetUser(roleReq.UserToken);

            var roles = PlayerDB.Instance.GetRoles(clientHandler.User.ID);
            var res = new RoleRes();
            foreach (var role in roles)
            {
                res.Infos.Add(new RoleInfo()
                {
                    Job = (JobType) role.job_type,
                    Level = role.level,
                    Name = role.name,
                    RoleId = role.id,
                });
            }
            clientHandler.Send(res);
        }

        [HandlerCfg(DCProtocolIds.LoginSvrReq)]
        public void HandleLoginSvrReq(ClientHandler clientHandler, int id, ProtoPacket packet)
        {
            var loginSvrReq = (LoginSvrReq) packet.ProtoObj;
            var role = PlayerDB.Instance.GetRole(loginSvrReq.RoleId);
            clientHandler.Role = role;
            var loginSvrRes = new LoginSvrRes();
            clientHandler.Send(loginSvrRes);
        }

    }
}