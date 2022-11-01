using UnityEngine;
using UnityEngine.SceneManagement;
namespace BriskBody.Scripts
{
    public class CommonlyUsedStaticMethods : MonoBehaviour
    {
        /// <summary>
        /// In build - Quits the game
        /// In playmode - Ends the playmode 
        /// </summary>
        public static void QuitGame()
        {
            Debug.Log($"Quitting Game");
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
				Application.Quit();
#endif
        }
        
        /// <summary>
        /// This will goto the next scene.
        /// </summary>
        public static void GotoNextScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
