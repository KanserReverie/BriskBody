using BriskBody.Scripts.UtilityScripts;
using UnityEngine;
namespace BriskBody.Scripts.Menus
{
    public class StartGame : MonoBehaviour
    {
        public void StartGameButton()
        {
            CommonlyUsedStaticMethods.GotoNextScene();
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CommonlyUsedStaticMethods.QuitGame();
            }
        }
    }
}
