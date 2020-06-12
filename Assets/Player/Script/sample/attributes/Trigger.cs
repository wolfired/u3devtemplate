using UnityEngine;

namespace sample.attributes
{
    /// <summary>
    /// 被<c>[RuntimeInitializeOnLoadMethod]</c>标记的静态方法是乱译执行的
    /// </summary>
    public class Trigger
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Fire4BeforeSceneLoad0()
        {
            Debug.Log("场景加载前0");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Fire4BeforeSceneLoad1()
        {
            Debug.Log("场景加载前1");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Fire4BeforeSceneLoad2()
        {
            Debug.Log("场景加载前2");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Fire4AfterSceneLoad0()
        {
            Debug.Log("场景加载后0, 也是在Awake()后调用的");
        }

        [RuntimeInitializeOnLoadMethod]
        public static void Fire4AfterSceneLoad1()
        {
            Debug.Log("场景加载后1, 也是在Awake()后调用的");
        }
    }
}