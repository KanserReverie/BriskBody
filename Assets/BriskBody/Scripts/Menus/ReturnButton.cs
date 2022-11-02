using BriskBody.Scripts.PlayerScripts;
using BriskBody.Scripts.UtilityScripts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BriskBody.Scripts.Menus
{
    public class ReturnButton : MonoBehaviour
    {
        private static ReturnButton _instance;
        public static ReturnButton Instance { get { return _instance; } }
        private void Awake()
        {
            MakeSingleton();
        }
        private void MakeSingleton()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            } else {
                _instance = this;
            }
        }
        
        [SerializeField] private GameObject QuitButton;
        [SerializeField] private GameObject MainMenuButton;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            CheckWhichReturnButtonToTurnOn();
        }
        
        public void CheckWhichReturnButtonToTurnOn()
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            if (currentSceneName is "MainMenu" or "EndScene")
            {
                TurnOnQuitButton();
            }
            else
            {
                TurnOnMainMenuButton();
            }
        }
        private void TurnOnMainMenuButton()
        {
            MainMenuButton.gameObject.SetActive(true);
            QuitButton.gameObject.SetActive(false);
        }
        private void TurnOnQuitButton()
        {
            MainMenuButton.gameObject.SetActive(false);
            QuitButton.gameObject.SetActive(true);
            if(Application.platform == RuntimePlatform.WebGLPlayer)
                QuitButton.gameObject.SetActive(false);
        }


        public void QuitButtonMethod()
        {
            CommonlyUsedStaticMethods.QuitGame();
        }
        
        public void MainMenuButtonMethod()
        {
            SceneManager.LoadScene(0);
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player)
            {
                Destroy(player.gameObject);
            }
            TurnOnQuitButton();
        }
    }
}
