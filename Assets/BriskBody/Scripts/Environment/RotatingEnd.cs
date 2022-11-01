using UnityEngine;

namespace BriskBody.Scripts.Environment
{
    public class RotatingEnd : MonoBehaviour
    {
        [SerializeField] private Vector3 rotation1 = new Vector3(0,0,-90);
        [SerializeField] private Vector3 rotation2 = new Vector3(0,0,-70);
        public float speed = 1.0f;

        private void Start()
        {
            this.transform.rotation = Quaternion.Euler(rotation1);
        }

        private void Update()
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(rotation1, rotation2, Mathf.PingPong(speed * Time.time, 1.0f)));
        }
    }
}
