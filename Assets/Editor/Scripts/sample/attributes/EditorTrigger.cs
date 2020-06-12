using UnityEditor;
using UnityEngine;

namespace sample.attributes
{
    [InitializeOnLoad]
    public class EditorTrigger
    {
        static EditorTrigger()
        {
            Debug.Log("Trigger: Unity starts or Run is pressed");
        }

        [InitializeOnLoadMethod]
        public static void EditorFirer()
        {
            Debug.Log("Firer: Unity starts or Run is pressed");
        }
    }
}
