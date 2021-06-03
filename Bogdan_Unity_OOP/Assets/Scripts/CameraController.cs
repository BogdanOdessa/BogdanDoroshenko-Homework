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
            transform.position = positionForCamera;
            if (IsTargetNotNull())
                transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position, Vector3.up);
        }

        private bool IsTargetNotNull()
        {
            return _target;
        }
    }

}


