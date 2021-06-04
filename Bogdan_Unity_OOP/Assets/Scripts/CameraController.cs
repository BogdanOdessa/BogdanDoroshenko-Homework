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

        private CameraShake cameraShake;

        private void Start()
        {
          var cameraShake = FindObjectOfType<CameraShake>().GetComponent<CameraShake>();         
        }

        void Update()
        {
            if (IsTargetNotNull())
                positionForCamera = _target.transform.position - _target.transform.forward * offsetDistance;
        }

        void LateUpdate()
        {
           

            if (IsTargetNotNull())
            {
                transform.position = positionForCamera;
                transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position, Vector3.up);
              
            }
        }
                

        private bool IsTargetNotNull()
        {
            return _target;
        }

        //public void Flay()
        //{
          

        //}

        //public IEnumerator Shake(float duration, float magnitude)
        //{
        //    Vector3 originalPoz = transform.position;

        //    float elapsed = 0.0f;

        //    while (elapsed < duration)
        //    {
        //        float x = Random.Range(-1f, 1f) * magnitude;
        //        float y = Random.Range(-1f, 1f) * magnitude;
        //        transform.position = new Vector3(x, y, originalPoz.z);
        //        elapsed += Time.time;

        //        yield return null;
        //    }

        //    transform.position = originalPoz;
        //}

        //public void Shake()
        //{
        //    cameraShake.shakeDuration = 1f;
        //}
    }

}


