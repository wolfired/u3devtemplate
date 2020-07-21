using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace exercise9000009
{
    public class MessageListener : MonoBehaviour
    {
        public string _listener_Name;
        void Start()
        {
        }

        void Update()
        {
        }

        public void Listen(string msg)
        {
            Debug.Log(_listener_Name + " get msg \"" + msg + "\"");
        }
    }
}
