using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.Camera
{
    [CreateAssetMenu(menuName = "TankGame/Camera/Camera Settings", fileName = "CameraSettings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation Speed")] [SerializeField] private float _rotationLerpSpeed;
        [Header("Position Speed")] [SerializeField] private float _positionLerpSpeed;
        [Header("Position Offset")][SerializeField] private Vector3 _positionOffset;

        public float RotationLerpSpeed => _rotationLerpSpeed;
        public float PositionLerpSpeed => _positionLerpSpeed;
        public Vector3 PositionOffset => _positionOffset;
    }
}
