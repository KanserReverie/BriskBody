using BriskBody.Scripts.PlayerScripts;
using UnityEngine;
namespace BriskBody.Scripts.Environment
{
    public class DeathBlock : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<PlayerController>().RestartLevel();
        }
    }
}
