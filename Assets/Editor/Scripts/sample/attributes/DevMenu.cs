using System.IO;

using UnityEditor;
using UnityEngine;

namespace sample.attributes
{
    /// <summary>
    /// <para><c>isValidateFunction</c>：是否为前置检查函数</para> 
    /// <para />
    /// <para><c>priority</c>：显示优先级，差值大于10会插入分隔线</para> 
    /// <para />
    /// <para><c>%</c>：对应Ctrl键</para>
    /// <para />
    /// <para><c>#</c>：对应Shift键</para>
    /// <para />
    /// <para><c>&amp;</c>：对应Alt键</para>
    /// <para />
    /// <para><c>_</c>：无需前置键</para>
    /// </summary>
    public class DevMenu
    {
        public class LockMenu
        {
            private static bool isLock = false;

            [MenuItem("DevMenu/LockMenu/Unlock %#&g", true)]
            public static bool UnlockChecker()
            {
                Debug.Log("UnlockChecker");
                return isLock;
            }

            [MenuItem("DevMenu/LockMenu/Unlock %#&g", false, 110)]
            public static void Unlock()
            {
                Debug.Log("Unlock");
                isLock = false;
            }

            [MenuItem("DevMenu/LockMenu/Lock _g", true)]
            public static bool LockChecker()
            {
                Debug.Log("LockChecker");
                return !isLock;
            }

            [MenuItem("DevMenu/LockMenu/Lock _g", false, 100)]
            public static void Lock()
            {
                Debug.Log("Lock");
                isLock = true;
            }
        }

        public class BundleMenu
        {
            [MenuItem("DevMenu/BundleMenu/Build")]
            public static void BuildAllAssetBundles()
            {
                string assetBundleDirectory = Path.Combine(Application.dataPath, "../AssetBundlesData");
                if (!Directory.Exists(assetBundleDirectory))
                {
                    Directory.CreateDirectory(assetBundleDirectory);
                }
                BuildPipeline.BuildAssetBundles(assetBundleDirectory,
                                                BuildAssetBundleOptions.None,
                                                BuildTarget.StandaloneWindows);
            }
        }
    }
}
