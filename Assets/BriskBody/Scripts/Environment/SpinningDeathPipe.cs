using UnityEngine;

namespace BriskBody.Scripts.Environment
{
    public class SpinningDeathPipe : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed = 50;
        private void Update()
        {
            this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
