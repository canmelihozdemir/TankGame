using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    [CreateAssetMenu(menuName = "TankGame/Rotate Settings",fileName ="RotateSettings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 1;
        public float Speed => _speed;

    }

}
