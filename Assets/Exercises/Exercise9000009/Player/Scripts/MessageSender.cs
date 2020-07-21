using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace exercise9000009
{
    public class MessageSender : MonoBehaviour
    {
        public string _sender_Name;
        public int gap;

        void Start()
        {
        }

        void Update()
        {
        }

        void OnGUI()
        {
            if (0 < gap)
            {
                GUILayout.Space(gap);
            }

            GUILayout.BeginHorizontal();

            if (GUILayout.Button(_sender_Name + " SendMessage"))
            {
                this.SendMessage("Listen", "i'm " + _sender_Name);
            }

            if (GUILayout.Button(_sender_Name + " SendMessageUpwards"))
            {
                this.SendMessageUpwards("Listen", "i'm " + _sender_Name);
            }

            if (GUILayout.Button(_sender_Name + " BroadcastMessage"))
            {
                this.BroadcastMessage("Listen", "i'm " + _sender_Name);
            }

            GUILayout.EndHorizontal();
        }
    }
}
