using System.Collections.Generic;
using DC.UI;
using Dcgameprotobuf;
using UnityEngine;
using UnityEngine.UI;

namespace DC
{
    public class SelectRoleUI : BaseUI, IListViewFuncs<RoleInfo, SelectRoleRoleItemViewUI>
    {
        private SelectRoleUIGen mUIGen;

        private SimpleListView<RoleInfo, SelectRoleRoleItemViewUI> mRoleListView;

        private RoleInfo mRoleInfo;

        public override void Init(params object[] param)
        {
            base.Init(param);
            mUIGen = gameObject.AddComponent<SelectRoleUIGen>();

            mUIGen.roleItemGameObject.SetActive(false);


            mRoleListView = new SimpleListView<RoleInfo, SelectRoleRoleItemViewUI>();
            mRoleListView.Init(this);
            mRoleListView.Create();

            mUIGen.addButton.onClick.AddListener(OnAddRole);
            mUIGen.confirmButton.onClick.AddListener(OnLogin);

            AddSmartListener(PlayerEvt.close_select_role_ui, Close);

            UpdateDetailUi();
        }

        void OnAddRole()
        {
            UiSys.ShowUi<AddRoleUI>();
        }

        void OnLogin()
        {
            var curRole = mRoleInfo;
            if (null == curRole)
            {
                return;
            }

            var req = new LoginSvrReq();
            req.RoleId = curRole.RoleId;

            SysBoxP.NetworkServiceP.Send(req, OnLoginSvrComplete, DCProtocolIds.LoginSvrRes);
        }

        void OnLoginSvrComplete(int id, ProtoPacket proto)
        {
            DCLog.Log("to game world");

            Close();
        }

        public void OnSelectRole(RoleInfo role)
        {
            mRoleInfo = role;

            UpdateDetailUi();
        }

        void UpdateDetailUi()
        {
            var roleInfo = mRoleInfo;
            mUIGen.detialGameObject.SetActive(roleInfo != null);

            if (roleInfo == null)
            {
                return;
            }

            mUIGen.detailNmeText.text = mRoleInfo.Name;
        }

        public List<RoleInfo> GetDataFunc()
        {
            return PlayerDataMgr.Instance.GetRoleList();
        }

        public SelectRoleRoleItemViewUI CreateViewItemFunc(int index)
        {
            var viewUIGo = Instantiate(mUIGen.roleItemGameObject, mUIGen.roleListRectTransform);
            viewUIGo.SetActive(true);

            var viewUI = viewUIGo.AddComponent<SelectRoleRoleItemViewUI>();
            viewUI.ViewGen.headButton.onClick.AddListener(() => { OnSelectRole(GetDataFunc()[index]); });

            return viewUI;
        }

        public void UpdateItemUiFunc(RoleInfo itemData, SelectRoleRoleItemViewUI roleItemUi)
        {
            var viewGen = roleItemUi.ViewGen;

            viewGen.nameText.text = itemData.Name;
        }
    }

    public class RoleItemView : MonoBehaviour
    {

        public Button headButton;
        public Image headImage;

        public Text nameText;


        void Awake()
        {
            headButton = transform.Find("cm_head").GetComponent<Button>();
            headImage = transform.Find("cm_head").GetComponent<Image>();

            nameText = transform.Find("cm_name").GetComponent<Text>();


        }

        

    }

    public class SelectRoleRoleItemViewUI : BaseItemUI<RoleItemView>
    {

    }
}