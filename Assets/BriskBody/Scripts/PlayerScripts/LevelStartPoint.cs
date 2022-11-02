using BriskBody.Scripts.Menus;
using UnityEngine;
namespace BriskBody.Scripts.PlayerScripts
{
    public class LevelStartPoint : MonoBehaviour
    {
        private void Start()
        {
            PlayerController playerInScene = FindObjectOfType<PlayerController>();
            if (playerInScene)
            {
                playerInScene.RestartLevel();
                playerInScene.ResetPlayerRigidbody();
            }
            ReturnButton returnButton = FindObjectOfType<ReturnButton>();
            if (returnButton)
            {
                returnButton.CheckWhichReturnButtonToTurnOn();
            }
        }
    }
}
