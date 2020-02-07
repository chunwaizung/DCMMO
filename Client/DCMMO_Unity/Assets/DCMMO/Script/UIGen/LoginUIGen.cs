
using UnityEngine;
using UnityEngine.UI;
namespace DC.UI
{
    public class LoginUIGen : MonoBehaviour
    {
		public Image nameImage;
		public InputField nameInputField;

		public Image passwordImage;
		public InputField passwordInputField;

		public Button loginButton;
		public Image loginImage;


        void Awake()
        {
			nameImage = transform.Find("cm_name").GetComponent<Image>();
			nameInputField = transform.Find("cm_name").GetComponent<InputField>();

			passwordImage = transform.Find("cm_password").GetComponent<Image>();
			passwordInputField = transform.Find("cm_password").GetComponent<InputField>();

			loginButton = transform.Find("cm_login").GetComponent<Button>();
			loginImage = transform.Find("cm_login").GetComponent<Image>();


        }
    }
}
