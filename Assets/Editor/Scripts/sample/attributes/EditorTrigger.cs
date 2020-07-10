using UnityEditor;
using UnityEngine;

using System.IO;

namespace sample.attributes
{
    [InitializeOnLoad]
    public class EditorTrigger
    {
        private static double _time_mark = 0;
        static EditorTrigger()
        {
            Debug.Log("InitializeOnLoad: Unity Start, or Run is pressed");

            EditorApplication.update += EditorUpdate;
        }

        [InitializeOnLoadMethod]
        public static void EditorFirer()
        {
            Debug.Log("InitializeOnLoadMethod: Unity Start, or Run is pressed");
        }

        private static void EditorUpdate()
        {
            if (60 > EditorApplication.timeSinceStartup - _time_mark)
            {
                return;
            }
            _time_mark = EditorApplication.timeSinceStartup;
            Debug.Log("EditorApplication.update: ");
        }
    }
}
