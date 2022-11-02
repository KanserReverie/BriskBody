using System;
using BriskBody.Scripts.PlayerScripts;
using UnityEngine;
namespace BriskBody.Scripts.Environment
{
    public class WinBlock : MonoBehaviour
    {
        private float triggerDelay;

        private void Start()
        {
            triggerDelay = 0.2f;
        }

        private void Update()
        {
            if (triggerDelay >= 0)
            {
                triggerDelay -= Time.time;
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (triggerDelay <= 0)
            {
                EndLevel();
            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (triggerDelay <= 0)
            {
                EndLevel();
            }
        }
        private void EndLevel()
        {
            GameUI.Instance.NextLevel();
        }
    }
}
