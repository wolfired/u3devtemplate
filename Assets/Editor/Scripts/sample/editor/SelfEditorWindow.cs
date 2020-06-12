using UnityEditor;
using UnityEngine;

namespace sample.editor
{
    public class SelfEditorWindow : EditorWindow
    {
        [MenuItem("DevMenu/Editor/SelfEditorWindow")]
        public static void ShowSelfEditorWindow()
        {
            EditorWindow.GetWindow(typeof(SelfEditorWindow));
        }

        public void OnGUI()
        {
            GUILayout.Button("Click");
        }
    }
}