using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if Exercise0001001
namespace exercise0001001
{
    public class ChangeCheckEditorWindow : EditorWindow
    {
        [MenuItem("Exercises/Exercise0001001/ChangeCheckEditorWindow")]
        public static void Open()
        {
            GetWindow<ChangeCheckEditorWindow>("ChangeCheck");
        }

        private float _sliderValue = 0;
        private string _labelFieldValue = "-";

        void OnGUI()
        {
            EditorGUILayout.LabelField("Slider value", _labelFieldValue);

            EditorGUI.BeginChangeCheck();

            _sliderValue = EditorGUILayout.Slider(_sliderValue, 0, 100);

            if (EditorGUI.EndChangeCheck())
            {
                _labelFieldValue = _sliderValue.ToString();
            }
        }
    }
}
#endif