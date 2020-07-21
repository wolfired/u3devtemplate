using System.Collections.Generic;
using UnityEngine;

namespace exercise9000002
{
    public class RandomShowCast : MonoBehaviour
    {
        public List<GameObject> _prefabs = new List<GameObject>();

        public AnimationCurve _curve;

        private GameObject _random_go;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (null != _random_go)
            {
                _random_go.transform.Rotate(new Vector3(Random.value, Random.value, Random.value));
            }
        }

        void OnGUI()
        {
            if (GUILayout.Button("Random Body"))
            {
                if (null != _random_go)
                {
                    Destroy(_random_go);
                }
                _random_go = Instantiate(_prefabs[Random.Range(0, _prefabs.Count)]);
                _random_go.transform.position = Vector3.zero;
            }

            if (GUILayout.Button("Random Color") && null != _random_go)
            {
                _random_go.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value, 1);
            }
        }
    }
}