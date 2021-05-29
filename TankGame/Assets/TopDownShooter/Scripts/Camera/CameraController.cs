using System.Collections;
using System.Collections.Generic;
using TankGame.Shooting;
using UnityEngine;

namespace TankGame.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;

        public ShootingManager shootingManager;

        private void Update()
        {
            FollowRotationOfTarget();
            FollowPositionOfTarget();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                shootingManager.Shoot(_cameraTransform.position, _cameraTransform.forward);
                Debug.Log("a");
            }
        }

        private void FollowRotationOfTarget()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position), Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void FollowPositionOfTarget()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position,_targetTransform.position+_cameraSettings.PositionOffset,Time.deltaTime*_cameraSettings.PositionLerpSpeed);
        }

    }
}

