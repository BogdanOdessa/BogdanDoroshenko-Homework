using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public class GameController : MonoBehaviour /*, IDisposable*/
    {
        [SerializeField] private InteractiveObject[] _interactiveObjects;

        private void Start()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }

        private void Update()
        {
            for (int i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IFlay flay)
                {
                    flay.Flay();
                }

                if (interactiveObject is IFlick flick)
                {
                    flick.Flick();
                }

                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotate();
                }
            }

        }
        //public void Dispose()
        //{
        //    foreach (var o in _interactiveObjects)
        //    {
        //        Destroy(o.gameObject);
        //    }
        //}
    }
}
    
    


