using System.Collections;
using System.Collections.Generic;
using DC.UI;
using Dcgameprotobuf;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DC
{
    public class AddRoleUI : BaseUI
    {
        private AddRoleUIGen mAddRoleUiGen;

        private PJobType mJob = PJobType.Saber;

        public override void Init(params object[] param)
        {
            base.Init(param);
            mAddRoleUiGen = gameObject.AddComponent<AddRoleUIGen>();
            mAddRoleUiGen.addButton.onClick.AddListener(OnAdd);
            mAddRoleUiGen.jobDropdown.onValueChanged.AddListener(OnDrop);

        }

        void OnDrop(int index)
        {
            mJob = (PJobType) (index + 1);
            //update ui with job
            UpdateUi();
        }

        void UpdateUi()
        {

        }

        void OnAdd()
        {
            var addRoleReq = new PAddRoleReq();
            addRoleReq.Job = mJob;
            addRoleReq.Name = mAddRoleUiGen.nameInputField.text;
            SysBoxP.NetworkServiceP.SendAutoRes(addRoleReq, OnAddRoleRes);
        }

        void OnAddRoleRes(int id, ProtoPacket proto)
        {
            //yeah , let's go to the game world
            DCLog.Log("yeah , let's go to the game world!");
            Close();
            
            MsgSys.Send(PlayerEvt.close_select_role_ui);

            var sceneId = ParamsCfgMgr.Instance.GetInt((int)PParamsConfig.BeginnerScene);

            LoadScene(sceneId);
        }

        void LoadScene(int sceneId)
        {
            var mapCfg = MapCfgMgr.Instance.GetMapConfigByID(sceneId);
            if (null != mapCfg)
            {
                SceneManager.LoadScene(System.IO.Path.GetFileNameWithoutExtension(mapCfg.AssetPath));
            }
            else
            {
                DCLog.Err("can not load level with id : {0}", sceneId);
            }
        }
    }
}