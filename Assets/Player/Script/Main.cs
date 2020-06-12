using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using u3devtools.network;
using u3devtools.logger;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public string my_name = "default";

    public GameObject wait_copy;
    // Use this for initialization
    private LoggerManager _logger_manager;

    void Awake()
    {
        _logger_manager = new LoggerManager(Path.Combine(Application.dataPath, "../player.log"), LogLevel.ON);
        Debug.Log("Awake");
        Debug.Log(Application.dataPath);
        _logger_manager.log(LogLevel.INFO, Path.Combine(Application.dataPath, "../player.log"));
        _logger_manager.log_person("HH");

        Debug.Log("Scene Count : " + SceneManager.sceneCount);
        Debug.Log("Scene Count In Build Settings : " + SceneManager.sceneCountInBuildSettings);
        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
    }
    void Start()
    {
        Debug.Log("Start");

        NetworkManager.ins.connect("127.0.0.1", "8080");

        var myLoadedAssetBundle
            = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "AssetBundles/AssetBundles"));
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        var manifest = myLoadedAssetBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        foreach (string name in manifest.GetAllAssetBundles())
        {
            print(name);
        }
        // Debug.Log(myLoadedAssetBundle.mainAsset);
        // foreach (string name in myLoadedAssetBundle.GetAllAssetNames())
        // {
        //     Debug.Log(name);
        // }
        // var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("cube");
        // GameObject go = Instantiate(prefab);
        // go.transform.position = Vector3.left * 3;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
        _logger_manager.print();
    }

    void FixedUpdate()
    {
        // Debug.Log("FixedUpdate");
    }

    void LateUpdate()
    {
        // Debug.Log("LateUpdate");
    }

    void OnGUI()
    {
        // Debug.Log("OnGUI");
    }

    void OnMouseOver()
    {
        // Debug.Log("OnMouseOver");
    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        _logger_manager.log_person("OnMouseDown");
        if (this.wait_copy.activeSelf)
        {
            Destroy(GameObject.Find("go"));

            SceneManager.LoadScene("Setting", LoadSceneMode.Single);
        }
        else
        {
            GameObject go = Instantiate(this.wait_copy);
            go.name = "go";
            go.SetActive(true);
            go.transform.position -= Vector3.up * 3;
        }
        this.wait_copy.SetActive(true);

    }
}
