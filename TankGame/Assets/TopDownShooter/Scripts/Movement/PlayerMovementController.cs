using System.Collections;
using System.Collections.Generic;
using TankGame.PlayerInput;
using UnityEngine;

namespace TankGame.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings _movementSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward*_inputData.Vertical* _movementSettings.VerticalSpeed));
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.right*_inputData.Horizontal*_movementSettings.HorizontalSpeed));
        }
    }

}
