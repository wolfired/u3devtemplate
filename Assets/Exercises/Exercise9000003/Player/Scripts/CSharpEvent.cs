using UnityEngine;

namespace Exercise9000003
{
    public class CSharpEvent : MonoBehaviour
    {
        // 声明代理
        public delegate void OnClick(string message);

        // 声明事件
        private event OnClick _onClick;
        private string _msg_in = "test";
        private string _msg_out = "";

        void Start()
        {
            _onClick += delegate (string message)
            {
                _msg_out = message;
            };
        }

        void Update()
        {
        }

        void OnGUI()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("C Sharp Event In: ");
            if (GUILayout.Button("Click"))
            {
                _onClick(_msg_in);
            }
            _msg_in = GUILayout.TextField(_msg_in);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("C Sharp Event Out: ");
            GUILayout.Label(_msg_out);
            GUILayout.EndHorizontal();
        }
    }
}
