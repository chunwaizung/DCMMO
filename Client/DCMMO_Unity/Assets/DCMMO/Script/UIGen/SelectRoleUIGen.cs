
using UnityEngine;
using UnityEngine.UI;
namespace DC.UI
{
    public class SelectRoleUIGen : MonoBehaviour
    {
		public ScrollRect roleSvScrollRect;
		public Image roleSvImage;

		public RectTransform roleListRectTransform;

		public GameObject roleItemGameObject;

		public Button confirmButton;
		public Image confirmImage;

		public Button addButton;
		public Image addImage;

		public GameObject detialGameObject;

		public Button detailHeadButton;
		public Image detailHeadImage;

		public Text detailNmeText;


        void Awake()
        {
			roleSvScrollRect = transform.Find("cm_roleSv").GetComponent<ScrollRect>();
			roleSvImage = transform.Find("cm_roleSv").GetComponent<Image>();

			roleListRectTransform = transform.Find("cm_roleSv/Viewport/tf_roleList").GetComponent<RectTransform>();

			roleItemGameObject = transform.Find("it_roleItem").gameObject;

			confirmButton = transform.Find("cm_confirm").GetComponent<Button>();
			confirmImage = transform.Find("cm_confirm").GetComponent<Image>();

			addButton = transform.Find("cm_add").GetComponent<Button>();
			addImage = transform.Find("cm_add").GetComponent<Image>();

			detialGameObject = transform.Find("go_detial").gameObject;

			detailHeadButton = transform.Find("go_detial/cm_detailHead").GetComponent<Button>();
			detailHeadImage = transform.Find("go_detial/cm_detailHead").GetComponent<Image>();

			detailNmeText = transform.Find("go_detial/cm_detailNme").GetComponent<Text>();


        }
    }
}
