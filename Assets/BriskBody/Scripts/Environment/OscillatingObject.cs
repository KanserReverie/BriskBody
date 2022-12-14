using UnityEngine;
namespace BriskBody.Scripts.Environment
{
    public class OscillatingObject : MonoBehaviour
    {
        [SerializeField] private Vector3 pos1 = new Vector3(-4,0,0);
        [SerializeField] private Vector3 pos2 = new Vector3(4,0,0);
        public float speed = 1.0f;

        private void Update()
        {
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        }
    }
}
