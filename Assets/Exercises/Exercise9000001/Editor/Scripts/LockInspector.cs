using System;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEditor;

#if Exercise9000001
namespace exercise9000001
{
    public static class LockInspector
    {
        [MenuItem("Exercises/Exercise9000001/Lock Inspector")]
        public static void Lock()
        {
            Type type = typeof(Editor).Assembly.GetType("UnityEditor.InspectorWindow");
            var window = EditorWindow.GetWindow(type);

            bool status = null != Selection.activeObject && !(bool)type.GetProperty("isLocked").GetValue(window);

            type.GetProperty("isLocked").SetValue(window, status);
        }
    }
}
#endif
