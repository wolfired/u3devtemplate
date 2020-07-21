using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    private delegate void Hi();

    private static int _static_field = 0;

    private static event Hi _event_handlers;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void ResetStaticFields()
    {
        _static_field = 0;
    }

    [RuntimeInitializeOnLoadMethod]
    static void ResetStaticEventHandlers()
    {
        _event_handlers -= StaticEventHandler;
    }

    void Start()
    {
        _event_handlers += StaticEventHandler;
    }

    void Update()
    {
    }

    void OnGUI()
    {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Static Fields"))
        {
            ++_static_field;
        }

        GUILayout.Label(_static_field.ToString());

        GUILayout.EndHorizontal();


        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Call Event Handles"))
        {
            _event_handlers();
        }

        GUILayout.EndHorizontal();
    }

    static void StaticEventHandler()
    {
        Debug.Log("This is a event handler");
    }
}
