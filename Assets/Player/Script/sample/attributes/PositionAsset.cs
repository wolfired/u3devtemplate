using UnityEngine;

namespace sample.attributes
{
    [CreateAssetMenu(fileName = "position.asset", menuName = "Custom Asset/Position Asset", order = 0)]
    [PreferBinarySerialization]
    public class PositionAsset : ScriptableObject
    {
        [ContextMenuItem("Reset", "resetPositionName", order = 0)]
        [Header("坐标名", order = 1)]
        public string positionName = "origin";

        [Header("坐标", order = 0)]
        public Vector3 position = Vector3.zero;

        [HideInInspector]
        public Vector3[] positionStack = new Vector3[] { };

        [ContextMenuItem("Reset", "resetPositionHeap", order = 0)]
        [Header("坐标堆", order = 0)]
        [SerializeField]
        private Vector3[] positionHeap = new Vector3[] { Vector3.zero, Vector3.one };

        private void resetPositionName()
        {
            this.positionName = "origin";
        }

        private void resetPositionHeap()
        {
            this.positionHeap = new Vector3[] { Vector3.zero, Vector3.one };
        }

        [ContextMenu("Print Position Heap")]
        private void printPositionHeap()
        {
            foreach (Vector3 position in this.positionHeap)
            {
                Debug.Log(string.Format("postion: ({0}, {1}, {2})", position.x
                , position.y, position.z));
            }
        }
    }
}
