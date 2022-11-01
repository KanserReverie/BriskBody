using System;
using UnityEngine;
namespace BriskBody.Scripts
{
    public class LevelStartPoint : MonoBehaviour
    {
        private void Start()
        {
            FindObjectOfType<Player>().RestartLevel();
        }
    }
}
