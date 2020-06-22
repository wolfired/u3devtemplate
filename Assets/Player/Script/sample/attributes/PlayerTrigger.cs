using UnityEngine;

namespace sample.attributes
{
    /// <summary>
    /// 被<c>[RuntimeInitializeOnLoadMethod]</c>标记的静态方法是乱译执行的
    /// </summary>
    public class PlayerTrigger
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Fire4BeforeSceneLoad0()
        {
            Debug.Log("RuntimeInitializeLoadType.BeforeSceneLoad 0: Before Scene Loaded");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Fire4BeforeSceneLoad1()
        {
            Debug.Log("RuntimeInitializeLoadType.BeforeSceneLoad 1: Before Scene Loaded");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Fire4BeforeSceneLoad2()
        {
            Debug.Log("RuntimeInitializeLoadType.BeforeSceneLoad 2: Before Scene Loaded");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Fire4AfterSceneLoad0()
        {
            Debug.Log("RuntimeInitializeLoadType.AfterSceneLoad 0: After Scene Loaded, After Awake() Called");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Fire4AfterSceneLoad1()
        {
            Debug.Log("RuntimeInitializeLoadType.AfterSceneLoad 1: After Scene Loaded, After Awake() Called");
        }

        [RuntimeInitializeOnLoadMethod]
        public static void Fire4AfterSceneLoad2()
        {
            Debug.Log("RuntimeInitializeOnLoadMethod: After Scene Loaded, After Awake() Called");
        }
    }
}
