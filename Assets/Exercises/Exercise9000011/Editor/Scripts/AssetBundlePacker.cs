using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if Exercise9000011
namespace exercise9000011
{
    public class ChangeCheckEditorWindow : EditorWindow
    {
        [MenuItem("Exercises/Exercise9000011/Pack")]
        public static void Open()
        {
            Debug.Log(0);
            var abm = BuildPipeline.BuildAssetBundles(Application.dataPath + "/Exercises/Exercise9000011/abs", BuildAssetBundleOptions.UncompressedAssetBundle|BuildAssetBundleOptions.ForceRebuildAssetBundle, BuildTarget.StandaloneWindows64);
            foreach (var item in abm.GetAllDependencies("prefabs/man"))
            {
                Debug.Log(item);
            }
        }
    }
}
#endif