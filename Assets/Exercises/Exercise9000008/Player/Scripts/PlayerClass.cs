using UnityEngine;

#if Exercise9000008
namespace exercise9000008
{
    public class PlayerClass
    {
        [RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        public static void AfterAssembliesLoaded()
        {
            Debug.Log("Call Runtime Class's Static Method: After Assemblies Loaded");
        }

        [RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void BeforeSplashScreen()
        {
            Debug.Log("Call Runtime Class's Static Method: Before Splash Screen");
        }

        [RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad()
        {
            Debug.Log("Call Runtime Class's Static Method: Before Scene Loaded");
        }

        [RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void AfterSceneLoad()
        {
            Debug.Log("Call Runtime Class's Static Method: After Scene Loaded");
        }
    }
}
#endif
