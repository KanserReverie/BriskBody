using System;
using BriskBody.Scripts.PlayerScripts;
using BriskBody.Scripts.UtilityScripts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BriskBody.Scripts.Menus
{
    public class EndGame : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI finalTimeText;
        private float finalTime;
        private bool runEndGameSequenceYet;
        private PlayerController playerInScene;
        private GameUI playerUI;

        public void Start()
        {
            runEndGameSequenceYet = false;
            
            TryToRunEndGameSequence();
            UpdateReturnButton();
        }
        
        private void UpdateReturnButton()
        {
            ReturnButton returnButton = FindObjectOfType<ReturnButton>();
            if (returnButton)
            {
                returnButton.CheckWhichReturnButtonToTurnOn();
            }
        }

        private void TryToRunEndGameSequence()
        {
            if (runEndGameSequenceYet)
                return;
            
            playerInScene = FindObjectOfType<PlayerController>();
            playerUI = FindObjectOfType<GameUI>();

            if (playerUI != null && playerInScene != null)
            {
                EndGameSequence();
            }
        }

        private void EndGameSequence()
        {
            finalTime = playerUI.GameTime;
            int gameMinutes = Mathf.FloorToInt(finalTime / 60);
            finalTimeText.text = ($"{gameMinutes:00}:{(finalTime-gameMinutes*60):00.000}");
            Destroy(playerInScene.gameObject);
            runEndGameSequenceYet = true;
        }
        
        public void MainMenuButton()
        {
            SceneManager.LoadScene(0);
        }
        
        private void Update()
        {
            TryToRunEndGameSequence();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CommonlyUsedStaticMethods.QuitGame();
            }
        }
    }
}
