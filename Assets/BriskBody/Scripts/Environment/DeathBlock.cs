using BriskBody.Scripts.PlayerScripts;
using UnityEngine;
namespace BriskBody.Scripts.Environment
{
    public class DeathBlock : MonoBehaviour
    {
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
