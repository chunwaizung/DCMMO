using DC.Model;
using DC.Net;
using Dcgameprotobuf;

namespace DC
{
    [HandlerClsCfg]
    public class PlayerHandler : BaseReqHandler
    {
        [HandlerCfg(DCProtocolIds.PAddRoleReq)]
        public void HandleAddRoleReq(ClientHandler clientHandler, int id, ProtoPacket packet)
        {
            var roleReq = (PAddRoleReq)packet.ProtoObj;
            var role = PlayerDB.Instance.CreateRole(clientHandler.User.ID, (int) roleReq.Job, roleReq.Name);
            clientHandler.Role = role;
            var addRoleRes = new PAddRoleRes();
            clientHandler.Send(addRoleRes);

            NotifyRoleEnterWorld(clientHandler);
        }

        private User CheckUser(string userToken)
        {
            var user = PlayerDB.Instance.GetUser(userToken);
            if (null == user)
            {
                user = PlayerDB.Instance.CreateUser(userToken);
            }
            return user;
        }

        [HandlerCfg(DCProtocolIds.PRoleReq)]
        public void HandleRoleReq(ClientHandler clientHandler,int id, ProtoPacket packet)
        {
            var roleReq = (PRoleReq) packet.ProtoObj;
            clientHandler.User = CheckUser(roleReq.UserToken);

            var roles = PlayerDB.Instance.GetRoles(clientHandler.User.ID);
            var res = new PRoleRes();
            foreach (var role in roles)
            {
                res.Infos.Add(new PRoleInfo()
                {
                    Job = (PJobType) role.job_type,
                    Level = role.level,
                    Name = role.name,
                    RoleId = role.id,
                });
            }
            clientHandler.Send(res);
        }

        [HandlerCfg(DCProtocolIds.PLoginSvrReq)]
        public void HandleLoginSvrReq(ClientHandler clientHandler, int id, ProtoPacket packet)
        {
            var loginSvrReq = (PLoginSvrReq) packet.ProtoObj;
            var role = PlayerDB.Instance.GetRole(loginSvrReq.RoleId);
            clientHandler.Role = role;
            var loginSvrRes = new PLoginSvrRes();
            clientHandler.Send(loginSvrRes);

            NotifyRoleEnterWorld(clientHandler);
        }


        void NotifyRoleEnterWorld(ClientHandler clientHandler)
        {

        }

        void NotifyRoleExitWorld(ClientHandler clientHandler)
        {

        }
    }
}