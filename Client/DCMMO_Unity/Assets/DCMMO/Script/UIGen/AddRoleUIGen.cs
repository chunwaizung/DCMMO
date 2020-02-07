
using UnityEngine;
using UnityEngine.UI;
namespace DC.UI
{
    public class AddRoleUIGen : MonoBehaviour
    {
		public Image nameImage;
		public InputField nameInputField;

		public Image jobImage;
		public Dropdown jobDropdown;

		public Button addButton;
		public Image addImage;


        void Awake()
        {
			nameImage = transform.Find("cm_name").GetComponent<Image>();
			nameInputField = transform.Find("cm_name").GetComponent<InputField>();

			jobImage = transform.Find("cm_job").GetComponent<Image>();
			jobDropdown = transform.Find("cm_job").GetComponent<Dropdown>();

			addButton = transform.Find("cm_add").GetComponent<Button>();
			addImage = transform.Find("cm_add").GetComponent<Image>();


        }
    }
}
