using UnityEngine;

namespace BriskBody.Scripts.Environment
{
    public class SpinningObject : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed = 50;
        
        private void Update()
        {
            this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
