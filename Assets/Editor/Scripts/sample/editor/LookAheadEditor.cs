using UnityEditor;
using UnityEngine;

namespace sample.editor
{
    [CustomEditor(typeof(LookAhead))]
    [CanEditMultipleObjects]
    public class LookAheadEditor : Editor
    {
        public SerializedProperty direction;
        public void OnEnable()
        {
            this.direction = this.serializedObject.FindProperty("direction");
        }

        public override void OnInspectorGUI()
        {
            this.serializedObject.Update();
            EditorGUILayout.PropertyField(this.direction);
            this.serializedObject.ApplyModifiedProperties();
        }
    }
}