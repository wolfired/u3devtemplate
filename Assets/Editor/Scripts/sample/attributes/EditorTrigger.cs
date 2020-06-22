using UnityEditor;
using UnityEngine;

using u3devtools.logger;
using System.IO;

namespace sample.attributes
{
    [InitializeOnLoad]
    public class EditorTrigger
    {
        private static double _time_mark = 0;
        private static LoggerManager _logger_manager;
        static EditorTrigger()
        {
            Debug.Log("InitializeOnLoad: Unity Start, or Run is pressed");

            EditorApplication.update += EditorUpdate;

            _logger_manager = new LoggerManager(Path.Combine(Application.dataPath, "../editor.log"), LogLevel.ON);
        }

        [InitializeOnLoadMethod]
        public static void EditorFirer()
        {
            Debug.Log("InitializeOnLoadMethod: Unity Start, or Run is pressed");
        }

        private static void EditorUpdate()
        {
            _logger_manager.print();

            if (60 > EditorApplication.timeSinceStartup - _time_mark)
            {
                return;
            }
            _time_mark = EditorApplication.timeSinceStartup;
            Debug.Log("EditorApplication.update: ");
        }
    }
}
