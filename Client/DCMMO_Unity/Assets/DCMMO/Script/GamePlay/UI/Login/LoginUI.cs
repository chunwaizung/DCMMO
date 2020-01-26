﻿using System;
using DC.UI;
using Dcgameprotobuf;

namespace DC
{
    public class LoginUI : BaseUI
    {
        public override void Init(params object[] param)
        {
            base.Init(param);

            AddSmartListener(GEvt.get_svr_list_suc, OnGetSvrList);
        }

        void OnGetSvrList()
        {
            
        }

        void OnLoginBtnClick()
        {
            //to login game svr
            var lastLoginSvr = GameServerDataMgr.Instance.GetLastLoginSvr();
            SysBoxP.NetworkServiceP.Connect(lastLoginSvr, () =>
            {
                SysBoxP.UnityMsgDis.PostAction(() =>
                {
                    Close();
                    MsgSys.Send(GEvt.connect_gsvr_suc);

                    PlayerNet.Instance.ReqRoleList(PlayerDataMgr.Instance.UserToken, (id, protoPkt) =>
                    {
                        UiSys.ShowUi<SelectRoleUI>();
                    });
                });
            });
        }
    }
}