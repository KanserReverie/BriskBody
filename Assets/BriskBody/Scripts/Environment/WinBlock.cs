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
                PlayerController player = FindObjectOfType<PlayerController>();
                if (player)
                {
                    player.ResetPlayerRigidbody();
                }
                GameUI.Instance.NextLevel();
            }
        }
    }
}
