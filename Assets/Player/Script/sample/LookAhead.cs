using UnityEngine;

namespace sample
{
    [ExecuteInEditMode]
    public class LookAhead : MonoBehaviour
    {
        public Vector3 direction = Vector3.zero;

        public void Update()
        {
            this.transform.LookAt(this.direction);
        }
    }
}
