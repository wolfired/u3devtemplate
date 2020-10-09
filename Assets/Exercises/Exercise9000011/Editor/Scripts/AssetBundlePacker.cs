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
        [System.Obsolete]
        public static void Open()
        {
            Debug.Log(0);

            List<AssetBundleBuild> list = new List<AssetBundleBuild>();

            AssetBundleBuild abb;

            abb = new AssetBundleBuild();
            abb.assetBundleName = "materials/sphere";
            abb.assetNames = new string[] { "Assets/Exercises/Exercise9000011/Materials/Sphere.mat" };
            list.Add(abb);

            abb = new AssetBundleBuild();
            abb.assetBundleName = "materials/cube";
            abb.assetNames = new string[] { "Assets/Exercises/Exercise9000011/Materials/Cube.mat" };
            list.Add(abb);

            abb = new AssetBundleBuild();
            abb.assetBundleName = "prefabs/man";
            abb.assetNames = new string[] { "Assets/Exercises/Exercise9000011/Prefabs/Man.prefab" };
            list.Add(abb);

            var abm = BuildPipeline.BuildAssetBundles(Application.dataPath + "/Exercises/Exercise9000011/abs", list.ToArray(), BuildAssetBundleOptions.UncompressedAssetBundle | BuildAssetBundleOptions.ForceRebuildAssetBundle | BuildAssetBundleOptions.DeterministicAssetBundle, BuildTarget.StandaloneWindows64);

            foreach (var item in abm.GetAllDependencies("prefabs/man"))
            {
                Debug.Log(item);
            }
        }
    }
}
#endif