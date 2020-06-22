using UnityEngine;

namespace sample.attributes
{
    [AddComponentMenu("Custom/SelfInfo", 0)]
    [DisallowMultipleComponent]
    [HelpURL("https://www.unity.com")]
    public class SelfInfo : MonoBehaviour
    {
        [ContextMenuItem("Reset", "resetMyName", order = 0)]
        [Header("我的名字", order = 0)]
        public string myName = "LinkWu";

        [Delayed(order = 0)]
        [Header("我的年龄", order = 0)]
        [Range(1, 100, order = 0)]
        public int myAge = 0;

        [HideInInspector]
        public int myMoney = 0;

        [Multiline(4, order = 0)]
        [Header("我的简介", order = 0)]
        public string myDesc = "冇聊效";

        [Header("我的经验", order = 0)]
        [Tooltip("我的工作经验", order = 0)]
        [TextArea(1, 4, order = 0)]
        public string myExperience = "";

        [Space(10, order = 0)]
        [SerializeField]
        [Header("我的邮箱", order = 0)]
        private string myEmail = "wjianl@qq.com";

        [ContextMenu("Print My Email", false, 1000000)]
        public void printMyEmail()
        {
            Debug.Log("My email is: " + myEmail);
        }

        private void resetMyName()
        {
            this.myName = "LinkWu";
        }
    }
}