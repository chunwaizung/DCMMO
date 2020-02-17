using System.Collections.Generic;
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
            var role = PlayerDB.Instance.AddRole(clientHandler.User.ID, (int) roleReq.Job, roleReq.Name);
            //equip
            
            //actor data
            var actorData = new PActorData();
            var jobConfigDefine = JobCfgMgr.Instance.Get(role.job_type, role.level);
            actorData.Hp = jobConfigDefine.MaxHp;
            actorData.Hp = jobConfigDefine.MaxMp;
            //task

            clientHandler.Role = role;
            var addRoleRes = new PAddRoleRes();
            clientHandler.Send(addRoleRes);

            NotifyRoleEnterWorld(clientHandler);
        }

        private DBUser CheckUser(string userToken)
        {
            var user = PlayerDB.Instance.GetUser(userToken);
            if (null == user)
            {
                user = PlayerDB.Instance.AddUser(userToken);
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
            var role = clientHandler.Role;

            var enterWorldNotify = new PRoleEnterWorldNotify();
            var actorInfo = new PPlayerActorInfo();
            actorInfo.ActorId = role.id;
            actorInfo.ActorName = clientHandler.Role.name;
                
            actorInfo.ActorData = DBToPUtil.DRoleDataToP(PlayerDB.Instance.GetRoleData(role.id));

            var actorInfoPos = new PVector3Int();
            actorInfoPos.X = clientHandler.Role.lastPosX;
            actorInfoPos.Z = clientHandler.Role.lastPosY;
            actorInfo.Pos = actorInfoPos;

            actorInfo.Job = (PJobType)role.job_type;
            actorInfo.Level = role.level;

            enterWorldNotify.PlayerActor = actorInfo;
            clientHandler.Send(enterWorldNotify);

            //scene and level
            var changeLevelNotify = new PChangeLevelNotify();
            changeLevelNotify.LevelId = clientHandler.Role.lastLevelId;
            clientHandler.Send(changeLevelNotify);
        }

        void NotifyRoleExitWorld(ClientHandler clientHandler)
        {

        }
    }
}