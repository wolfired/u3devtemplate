using UnityEngine;

namespace sample.attributes
{
    [CreateAssetMenu(fileName = "custom.asset", menuName = "Custom Asset/PositionAsset", order = 0)]
    [PreferBinarySerialization]
    public class PositionAsset : ScriptableObject
    {
        [ContextMenuItem("Reset", "resetPositionName", order = 0)]
        [Header("坐标名", order = 1)]
        public string positionName = "origin";

        [Header("坐标", order = 0)]
        public Vector3 position = Vector3.zero;

        [HideInInspector]
        public Vector3[] postionStack = new Vector3[] { };

        [Header("坐标堆", order = 0)]
        [SerializeField]
        private Vector3[] postionHeap = new Vector3[] { };

        private void resetPositionName()
        {
            this.positionName = "origin";
        }
    }
}
