using UnityEngine;
using UnityEngine.Events;

namespace Exercise9000003
{
    public class UnityEvent : MonoBehaviour
    {
        public class OnClick : UnityEvent<string> { }

        private OnClick _onClick;
        private string _msg_in = "test";
        private string _msg_out = "";

        void Start()
        {
            _onClick = new OnClick();
            _onClick.AddListener(delegate (string message)
            {
                _msg_out = message;
            });
        }

        void Update()
        {
        }

        void OnGUI()
        {
            GUILayout.Space(60);

            GUILayout.BeginHorizontal();
            GUILayout.Label("Unity Event In: ");
            if (GUILayout.Button("Click"))
            {
                _onClick.Invoke(_msg_in);
            }
            _msg_in = GUILayout.TextField(_msg_in);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Unity Event Out: ");
            GUILayout.Label(_msg_out);
            GUILayout.EndHorizontal();
        }
    }
}
