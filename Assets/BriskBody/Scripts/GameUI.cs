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
            DontDestroyOnLoad(this);
            RefreshLevelUI();
            gameTime = 0f;
            timerText.text = $"{gameTime:00:00.000}";
        }
        
        private void Update()
        {
            gameTime += Time.deltaTime;
            timerText.text = $"{gameTime:00:00.000}";
        }

        public void RefreshLevelUI()
        {
            level = SceneManager.GetActiveScene().buildIndex;
            levelText.text = $"{level}";
        }

        public void NextLevel()
        {
            CommonlyUsedStaticMethods.GotoNextScene();
            RefreshLevelUI();
        }
    }
}
