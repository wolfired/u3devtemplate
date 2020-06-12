using UnityEditor;
using UnityEngine;

namespace sample.editor
{
    [CustomEditor(typeof(LookAhead))]
    // [CanEditMultipleObjects]
    public class LookAheadEditor : Editor
    {
        public SerializedProperty lookAhead;
        public void OnEnable()
        {
            this.lookAhead = this.serializedObject.FindProperty("lookAhead");
            Debug.Log(this.lookAhead);
        }

        public override void OnInspectorGUI()
        {
            this.serializedObject.Update();
            EditorGUILayout.PropertyField(this.lookAhead);
            this.serializedObject.ApplyModifiedProperties();
        }
    }
}