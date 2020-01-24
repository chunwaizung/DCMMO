using System;
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

                    var roleReq = new RoleReq();
                    roleReq.UserToken = UserDataMgr.Instance.UserToken;

                    SysBoxP.NetworkServiceP.Send(roleReq, (id, rst) =>
                    {
                        UiSys.ShowUi<SelectRoleUI>();
                    });
                });
            });
        }
    }
}