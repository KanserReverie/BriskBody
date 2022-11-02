using UnityEngine;
using UnityEngine.SceneManagement;
namespace BriskBody.Scripts.PlayerScripts
{
    public class PlayerController : MonoBehaviour
    {
        private bool gamePaused;
        [SerializeField] private GameObject pauseText;
        [SerializeField] private GameObject unPauseText;
        private Rigidbody playerRigidbody;
        private Vector3 playerRigidbodyVelocity;
        private Vector3 playerRigidbodyAngularVelocity;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            playerRigidbody = GetComponentInChildren<Rigidbody>();
            RestartLevel();
            playerRigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
            Time.timeScale = 1.2f;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
                Destroy(gameObject);
            }
        }

        public void RestartLevel()
        {
            MoveToStartPoint();
            ResetPlayerRigidbody();
            SavePlayerRigidbody();
            UnPauseGame();
            GameUI.Instance.RefreshLevelUI();
        }
        private void MoveToStartPoint()
        {
            Transform startPoint = FindObjectOfType<LevelStartPoint>().transform;
            if (startPoint)
            {
                playerRigidbody = GetComponentInChildren<Rigidbody>();
                playerRigidbody.gameObject.transform.position = startPoint.position; 
                playerRigidbody.gameObject.transform.rotation = startPoint.rotation;
            }
        }

        public void ResetPlayerRigidbody()
        {
            playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.angularVelocity = Vector3.zero;
        }

        public void PressButton()
        {
            if (gamePaused)
            {
                UnPauseGame();
            }
            else
            {
                PauseGame();
            }
        }
        
        private void PauseGame()
        {
            gamePaused = true;
            unPauseText.SetActive(true);
            pauseText.SetActive(false);
            SavePlayerRigidbody();
            FreezePlayer();
        }
        private void FreezePlayer()
        {
            playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
        
        private void SavePlayerRigidbody()
        {
            playerRigidbodyVelocity = playerRigidbody.velocity;
            playerRigidbodyAngularVelocity = playerRigidbody.angularVelocity;
        }

        private void UnPauseGame()
        {
            gamePaused = false;
            unPauseText.SetActive(false);
            pauseText.SetActive(true);
            UnFreezePlayer();
            LoadPlayerRigidbody();
        }
        private void UnFreezePlayer()
        {
            playerRigidbody.constraints = RigidbodyConstraints.None;
            playerRigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
        }
        
        private void LoadPlayerRigidbody()
        {
            playerRigidbody.velocity = playerRigidbodyVelocity;
            playerRigidbody.angularVelocity = playerRigidbodyAngularVelocity;
        }
    }
}
