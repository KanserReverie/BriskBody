using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace BriskBody.Scripts
{
    public class GameUI : MonoBehaviour
    {
        private static GameUI _instance;
        public static GameUI Instance { get { return _instance; } }
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

        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private TextMeshProUGUI levelText;
        private float gameTime;
        private float level;

        private void Start()
        {
            level = SceneManager.GetActiveScene().buildIndex - 1;
            DontDestroyOnLoad(this);
            levelText.text = $"{level}";
            gameTime = 0f;
            timerText.text = $"{gameTime:0.000}";
        }
        
        private void Update()
        {
            gameTime += Time.deltaTime;
            timerText.text = $"{gameTime:0.000}";
        }

        public void NextLevel()
        {
            CommonlyUsedStaticMethods.GotoNextScene();
            level = SceneManager.GetActiveScene().buildIndex - 1;
            levelText.text = $"{level}";
        }
    }
}
