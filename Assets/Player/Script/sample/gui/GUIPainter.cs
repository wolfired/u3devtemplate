using UnityEngine;

namespace sample.gui
{
    /// <summary>
    /// <para><c>GUIElement</c>：用于在GUI中显示图像或文本字符串的基类，包含了所有GUI元素的基础功能。</para>
    /// <para />
    /// <para><c>GUIContent</c>：GUI元素的内容，定义要渲染什么</para>
    /// <para />
    /// <para><c>GUIStyle</c>：GUI元素的样式信息，定义要如何渲染</para>
    /// <para />
    /// <para><c>GUI</c>：Unity GUI接口，需要手动布局。</para>
    /// <para />
    /// <para><c>GUILayout</c>：Unity GUI接口，具有自动布局功能。</para>
    /// <para />
    /// <para><c>GUILayoutOption</c>：内部用于向<c>GUILayout</c>函数传递布局选项的类。你无须直接创建它，而是通过<c>GUILayout</c>的相关方法创建它。</para>
    /// </summary>
    [AddComponentMenu("Custom/GUIPainter", 0)]
    public class GUIPainter : MonoBehaviour
    {
        public Texture toggleSelected;
        public Texture toggleUnselect;

        private bool isToggled = false;

        public void OnGUI()
        {
            GUILayout.Box("a box");

            GUILayout.BeginArea(new Rect(128, 128, 256, 256), "area");
            if (GUILayout.Button("Click me"))
            {
                Debug.Log("Clicked me");
            }

            GUIContent content = new GUIContent(this.isToggled ? this.toggleSelected : this.toggleUnselect);
            GUIStyle style = new GUIStyle();
            style.CalcSize(content);

            this.isToggled = GUILayout.Toggle(this.isToggled, content, style);

            GUILayout.EndArea();
        }
    }
}
