﻿using System.Collections.Generic;
using DC.Net;
using Dcgameprotobuf;

namespace DC
{
    public class PlayerDataMgr : GameBehaviourSingleton<PlayerDataMgr>
    {
        public string UserName;

        public string Password;

        public string UserToken;

        List<PRoleInfo> mRoleList = new List<PRoleInfo>();

        public PRoleInfo CurRole;

        protected override void OnInit()
        {
            base.OnInit();

            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.PRoleRes, OnRoleRes);
            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.PAddRoleRes, OnAddRoleRes);
            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.PLoginSvrRes, OnLoginSvrRes);
            SysBox.Instance.NetworkServiceP.AddHandler(DCProtocolIds.PRoleEnterWorldNotify, OnPRoleEnterWorldNotify);
        }

        void OnPRoleEnterWorldNotify(int id, ProtoPacket proto)
        {
            //create role model and load scene
            var notify = (PRoleEnterWorldNotify) proto.ProtoObj;
            var actorInfo = notify.PlayerActor;

            var actorSys = SysBoxP.ActorSysP;
            var actor = actorSys.CreateActor(actorInfo);
            actorSys.Add(actor.GetActorGId(), actor);
        }

        void OnLoginSvrRes(int id, ProtoPacket proto)
        {
            
        }

        void OnAddRoleRes(int id, ProtoPacket proto)
        {
            var roleInfo = (PRoleInfo) proto.ProtoObj;
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

            var roleRes = (PRoleRes) protoPkt.ProtoObj;
            mRoleList.Clear();
            mRoleList.AddRange(roleRes.Infos);
        }

        public List<PRoleInfo> GetRoleList()
        {
            return mRoleList;
        }
    }

    public enum ProtoErrorType
    {

    }

}