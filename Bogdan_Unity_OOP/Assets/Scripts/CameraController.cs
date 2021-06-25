using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MazeControllers
{
    public sealed class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float offsetDistance = 3f;
        private Vector3 positionForCamera;

        void Update()
        {
            if(IsTargetNotNull())
            positionForCamera = _target.transform.position - _target.transform.forward * offsetDistance;
        }

        void LateUpdate()
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            transform.position = positionForCamera;
            if (IsTargetNotNull())
                transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position, Vector3.up);
=======
=======
>>>>>>> Stashed changes
            //_mainCamera.position = _player.position + _offset;

            originalPos = _mainCamera.localPosition;
            if (_player != null)
            {

                if (shakeDuration > 0)
                {
                    _mainCamera.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

                    shakeDuration -= Time.deltaTime * decreaseFactor;
                }
                else
                {
                    shakeDuration = 0f;
                    //_mainCamera.localPosition = originalPos;
                    _mainCamera.position = _player.position + _offset;
                }
            }



>>>>>>> Stashed changes
        }

        private bool IsTargetNotNull()
        {
            return _target;
        }
    }

}


