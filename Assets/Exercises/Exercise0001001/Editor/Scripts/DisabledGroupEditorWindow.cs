using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if Exercise0001001
namespace exercise0001001
{
    public class DisabledGroupEditorWindow : EditorWindow
    {
        [MenuItem("Exercises/Exercise0001001/DisabledGroupEditorWindow")]
        public static void Open()
        {
            GetWindow<DisabledGroupEditorWindow>("DisabledGroup");
        }

        private bool _disable = false;
        private float _sliderValue = 0;

        void OnGUI()
        {
            _disable = EditorGUILayout.Toggle("Disable", _disable);

            EditorGUI.BeginDisabledGroup(_disable);

            _sliderValue = EditorGUILayout.Slider(_sliderValue, 0, 100);

            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif