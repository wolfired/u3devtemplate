using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

using u3devtools.logger;

[AddComponentMenu("Custom/Booter")]
[DisallowMultipleComponent]
public class Booter : MonoBehaviour
{
    private LoggerManager _logger_manager;

    void Awake()
    {
        _logger_manager = new LoggerManager(Path.Combine(Application.dataPath, "../player.log"), LogLevel.ON);
    }

    void Start()
    {
    }

    void Update()
    {
        _logger_manager.print();
    }

    void FixedUpdate()
    {
    }

    void LateUpdate()
    {
    }

    void OnGUI()
    {
    }

    void OnMouseOver()
    {
    }

    void OnMouseDown()
    {
    }
}
