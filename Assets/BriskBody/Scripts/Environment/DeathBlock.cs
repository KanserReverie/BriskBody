using BriskBody.Scripts.PlayerScripts;
using UnityEngine;
namespace BriskBody.Scripts.Environment
{
    public class DeathBlock : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player)
            {
                player.RestartLevel();
            }
        }
        private void OnTriggerStay(Collider other)
        {
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player)
            {
                player.RestartLevel();
            }
        }
    }
}
