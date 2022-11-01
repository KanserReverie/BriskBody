using System;
using UnityEngine;

namespace BriskBody.Scripts
{
    public class WinBlock : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            GameUI.Instance.NextLevel();
        }
    }
}
