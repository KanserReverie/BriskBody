using UnityEngine;

namespace BriskBody.Scripts
{
    public class DeathBlock : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<Player>().RestartLevel();
        }
    }
}
