using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;

        private void Update()
        {
            transform.Rotate(Vector3.up,Time.deltaTime* _rotateSettings.Speed);
        }
    }
}

