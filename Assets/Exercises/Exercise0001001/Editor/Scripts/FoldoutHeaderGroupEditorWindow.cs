using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if Exercise0001001
namespace exercise0001001
{
    public class FoldoutHeaderGroupEditorWindow : EditorWindow
    {
        [MenuItem("Exercises/Exercise0001001/FoldoutHeaderGroupEditorWindow")]
        public static void Open()
        {
            GetWindow<FoldoutHeaderGroupEditorWindow>("DisabledGroup");
        }

        private static string DEFAULT_USERNAME = "wolfired";

        private bool _foldout_status = false;
        private string _foldout_title = "Input Username";
        private string _username = DEFAULT_USERNAME;

        void OnGUI()
        {
            _foldout_status = EditorGUI.BeginFoldoutHeaderGroup(new Rect(8, 8, 256, 20), _foldout_status, _foldout_title, null, this.onHeaderAction);

            if (_foldout_status)
            {
                _foldout_title = "Edit Username";

                _username = EditorGUI.TextField(new Rect(8, 28, 256, 20), "User Name", _username);
            }
            else
            {
                _foldout_title = "Input Username";
            }

            EditorGUI.EndFoldoutHeaderGroup();
        }

        void onHeaderAction(Rect rect)
        {
            var menu = new GenericMenu();
            menu.AddItem(new GUIContent("Reset username to " + DEFAULT_USERNAME), false, resetUsername);
            menu.DropDown(rect);
        }

        void resetUsername()
        {
            _username = DEFAULT_USERNAME;
        }
    }
}
#endif