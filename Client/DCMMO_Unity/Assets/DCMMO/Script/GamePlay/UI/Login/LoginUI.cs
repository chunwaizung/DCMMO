using System;
using System.Collections;
using System.Collections.Generic;
using DC.UI;
using Dcgameprotobuf;
using SimpleJSON;
using UnityEngine.Networking;

namespace DC
{
    public class LoginUI : BaseUI
    {
        public LoginUIGen mUIGen;

        public override void Init(params object[] param)
        {
            base.Init(param);

            mUIGen = gameObject.AddComponent<LoginUIGen>();

            mUIGen.nameInputField.text = "1";
            mUIGen.passwordInputField.text = "1";

            AddSmartListener(SysEvt.get_svr_list_suc, OnGetSvrList);

            mUIGen.loginButton.onClick.AddListener(OnLoginBtnClick);
        }

        void OnGetSvrList()
        {
            
        }

        IEnumerator LoginApp(string uname, string upsw, Action<int, string> callback)
        {
            var paramDic = new Dictionary<string, object>();
            paramDic.Add("user_name", uname);
            paramDic.Add("user_psw", upsw);
            var request = UnityWebRequest.Get(HttpUtil.CreateUrl("http://localhost:8080/polls/login", paramDic));

            yield return request.SendWebRequest();
            if (request.isHttpError || request.isNetworkError)
            {
                callback?.Invoke(2, request.error);
            }
            callback?.Invoke(1, request.downloadHandler.text);
        }

        void OnLoginComplete(int code, string result)
        {
            if (code == 1)
            {
                var jsonNode = JSON.Parse(result);
                int svrCode = jsonNode["result"];
                if (svrCode == 1)
                {
                    var token = jsonNode["token"];
                    DCLog.Log(token);
                    PlayerDataMgr.Instance.UserToken = token;

                    //to login game svr
                    var svrCfg = GameServerDataMgr.Instance.GetLastLoginSvr();
                    RequestRoleData(svrCfg);
                }
            }
            else if (code == 2)
            {
                DCLog.LogEx("net or http error ", result);
            }
        }

        void OnLoginBtnClick()
        {
            var uname = mUIGen.nameInputField.text;
            var upsw = mUIGen.passwordInputField.text;

            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(upsw))
            {
                return;
            }

            DCCoroutine.Instance.StartCoroutine(LoginApp(uname, upsw, OnLoginComplete));
        }

        void RequestRoleData(ServerConfig svrCfg)
        {
            SysBoxP.NetworkServiceP.Connect(svrCfg, () =>
            {
                SysBoxP.UnityMsgDis.PostAction(() =>
                {
                    MsgSys.Send(SysEvt.connect_gsvr_suc);

                    PlayerNet.Instance.ReqRoleList(PlayerDataMgr.Instance.UserToken, (id, protoPkt) =>
                    {
                        Close();

                        UiSys.ShowUi<SelectRoleUI>();
                    });
                });
            });
        }
    }
}