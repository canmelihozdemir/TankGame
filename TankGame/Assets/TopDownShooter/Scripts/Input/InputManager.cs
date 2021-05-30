using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private InputData _rotationInputData;
        private Vector3 _lastInputData;


        private void Update()
        {
            _inputData.Horizontal = Input.GetAxis("Horizontal");
            _inputData.Vertical = Input.GetAxis("Vertical");

            _rotationInputData.Horizontal = Input.mousePosition.x - _lastInputData.x;
        }
    }

}
