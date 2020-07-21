using UnityEngine;
using UnityEditor;

#if Exercise9000007
namespace exercise9000007
{
    [InitializeOnLoadAttribute]//只能用于类, 且对类的静态构造方法有效
    public class EditorClass
    {
        static EditorClass()
        {
            Debug.Log("Call Class's static Constructor On Unity Load Or Scripts Recompiled");

            double time_mark_pre = 0;

            EditorApplication.update += delegate ()
            {
                double time_mark_cur = EditorApplication.timeSinceStartup;
                if (60 > time_mark_cur - time_mark_pre)
                {
                    return;
                }
                time_mark_pre = time_mark_cur;
                Debug.Log("Editor Update Callback in 60s");
            };
        }

        [InitializeOnLoadMethodAttribute]//需要静态方法
        static void OnUnityLoadOrScriptsRecompiled()
        {
            Debug.Log("Call Class's Static Method On Unity Load Or Scripts Recompiled");
        }

        [InitializeOnEnterPlayModeAttribute]
        static void OnEnterPlayMode()
        {
            Debug.Log("Call Class's Static Method On Enter Play Mode");
        }
    }
}
#endif