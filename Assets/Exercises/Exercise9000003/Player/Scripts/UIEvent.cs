using UnityEngine;
using UnityEngine.UI;

namespace Exercise9000003
{
    public class UIEvent : MonoBehaviour
    {
        public Button _button;
        private string _msg_in = "test";
        private string _msg_out = "";

        void Start()
        {
            _button.onClick.AddListener(delegate ()
            {
                _msg_out = _msg_in;
            });
        }

        void Update()
        {
        }

        void OnGUI()
        {
            GUILayout.Space(120);

            GUILayout.BeginHorizontal();
            GUILayout.Label("Unity Event In: ");
            _msg_in = GUILayout.TextField(_msg_in);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("UI Event Out: ");
            GUILayout.Label(_msg_out);
            GUILayout.EndHorizontal();
        }
    }
}
