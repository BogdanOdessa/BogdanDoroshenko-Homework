using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game
{
    public sealed class CameraController : IExecute
    {
        private Transform _player;
        private Transform _mainCamera;
        private Vector3 _offset;
        private Vector3 originalPos;

        [SerializeField] private float shakeDuration = 0f;

        [SerializeField] private float shakeAmount = 0.02f;
        [SerializeField] private float decreaseFactor = 3f;

        public CameraController(Transform player, Transform mainCamera)
        {
            _player = player;
            _mainCamera = mainCamera;
            _mainCamera.LookAt(_player);
            _offset = _mainCamera.position - _player.position;
        }


        public void Execute()
        {
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



        }

        public void Shake()
        {
            shakeDuration = 1f;
        }

        


        #region PreviousCamera
        //void Update()
        //{
        //    if (IsTargetNotNull())
        //        positionForCamera = _target.transform.position - _target.transform.forward * offsetDistance;
        //}

        //void LateUpdate()
        //{


        //    if (IsTargetNotNull())
        //    {
        //        transform.position = positionForCamera;
        //        transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position, Vector3.up);

        //    }
        //}

        //private bool IsTargetNotNull()
        //{
        //    return _target;
        //}
        #endregion
    }

}


