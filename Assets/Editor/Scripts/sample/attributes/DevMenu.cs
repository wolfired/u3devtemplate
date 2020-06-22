using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            [MenuItem("DevMenu/LockMenu/Lock", true)]
            public static bool LockChecker()
            {
                Debug.Log("LockChecker");
                return !isLock;
            }

            [MenuItem("DevMenu/LockMenu/Lock", false, 100)]
            public static void Lock()
            {
                Debug.Log("Lock");
                isLock = true;
            }
        }

        public class AssetMenu
        {
            [MenuItem("DevMenu/AssetMenu/Show")]
            public static void ShowAllAsset()
            {
                string[] paths = AssetMenu.GetAllAssetPaths("Assets/");
                foreach (string path in paths)
                {
                    Debug.Log(path);
                }
            }

            public static string[] GetAllAssetPaths(string starts_with, bool exclude_script = true, bool exclude_folder = true)
            {
                List<string> list = new List<string>();
                string[] paths = AssetDatabase.GetAllAssetPaths();
                foreach (string path in paths)
                {
                    if (path.StartsWith(starts_with))
                    {
                        if (exclude_folder && AssetDatabase.IsValidFolder(path))
                        {
                            continue;
                        }
                        if (exclude_script && "UnityEditor.MonoScript" == AssetDatabase.GetMainAssetTypeAtPath(path).ToString())
                        {
                            continue;
                        }
                        if (path.EndsWith("/README.md"))
                        {
                            continue;
                        }
                        list.Add(path);
                    }
                }
                return list.ToArray();
            }
        }

        public class BundleMenu
        {
            private static readonly string DIR_OUT = Path.Combine(Application.dataPath, "../AssetBundlesData");

            [MenuItem("DevMenu/BundleMenu/Show")]
            public static void ShowBundles()
            {
                string[] names = AssetDatabase.GetAllAssetBundleNames();
                foreach (string name in names)
                {
                    Debug.Log(name);
                }
            }

            [MenuItem("DevMenu/BundleMenu/Build")]
            public static void BuildBundles()
            {
                string[] paths = Directory.GetDirectories(Path.Combine(Application.dataPath, String.Join(Path.DirectorySeparatorChar.ToString(), new string[] { "Player", "Bundles" })));

                foreach (string path in paths)
                {
                    BuildBundle(path);
                }

                string[] names = AssetDatabase.GetAllAssetBundleNames();

                if (0 < names.Count())
                {
                    if (!Directory.Exists(DIR_OUT))
                    {
                        Directory.CreateDirectory(DIR_OUT);
                    }

                    BuildPipeline.BuildAssetBundles(DIR_OUT,
                                                    BuildAssetBundleOptions.None,
                                                    BuildTarget.StandaloneWindows);
                }
            }

            private static void BuildBundle(string dir_target)
            {
                string[] paths = Directory.GetDirectories(dir_target);
                foreach (string path in paths)
                {
                    BuildBundle(path);
                }

                List<string> assetNames = new List<string>();
                List<string> addressableNames = new List<string>();

                string[] files = Directory.GetFiles(dir_target);
                foreach (string file in files)
                {
                    string suffix = Path.GetExtension(file);
                    if (".cs" == suffix || ".md" == suffix || ".meta" == suffix)
                    {
                        continue;
                    }
                    assetNames.Add("Assets" + file.Replace(Application.dataPath, "").Replace(Path.DirectorySeparatorChar, '/'));
                    addressableNames.Add(file.Replace(Application.dataPath + @"\Player\Bundles\", "").Replace(Path.DirectorySeparatorChar, '/'));
                }

                if (0 == assetNames.Count())
                {
                    return;
                }

                string[] words = dir_target.Split(new char[] { Path.DirectorySeparatorChar }).Reverse().ToArray();
                foreach (string word in words)
                {
                    if (Char.IsUpper(word.ToCharArray(0, 1)[0]))
                    {
                        words = words.Take(Array.IndexOf(words, word)).Reverse().ToArray();
                        break;
                    }
                }

                AssetBundleBuild abb = new AssetBundleBuild();
                abb.assetBundleName = String.Join("/", words);
                abb.assetNames = assetNames.ToArray();
                abb.addressableNames = addressableNames.ToArray();

                if (!Directory.Exists(DIR_OUT))
                {
                    Directory.CreateDirectory(DIR_OUT);
                }
                BuildPipeline.BuildAssetBundles(DIR_OUT,
                                                new AssetBundleBuild[] { abb },
                                                BuildAssetBundleOptions.None,
                                                BuildTarget.StandaloneWindows);
            }
        }
    }
}
