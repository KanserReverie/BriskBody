using BriskBody.Scripts.UtilityScripts;
using UnityEngine;
namespace BriskBody.Scripts.Environment
{
    public class StartGame : MonoBehaviour
    {
        public void StartGameButton()
        {
            CommonlyUsedStaticMethods.GotoNextScene();
        }
    }
}
