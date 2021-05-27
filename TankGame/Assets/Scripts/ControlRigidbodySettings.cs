using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    [CreateAssetMenu(menuName = "TankGame/Control Rigidbody Settings", fileName = "ControlRigidbodySettings")]
    public class ControlRigidbodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpForce;

        public  Vector3 JumpForce => _jumpForce;

    }

}
