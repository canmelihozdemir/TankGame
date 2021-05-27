using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private ControlRigidbodySettings _controlRigidbodySettings;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(_controlRigidbodySettings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}

