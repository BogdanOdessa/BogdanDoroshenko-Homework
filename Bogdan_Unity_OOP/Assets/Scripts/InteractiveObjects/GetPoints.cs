
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public delegate void MyDelegate();
    public sealed class GetPoints : InteractiveObject, IRotation
    {

        public event MyDelegate MyEventOnPointChange;

        private DisplayText _displayBonuses;

        private float _rotationSpeed = 20f;

        [SerializeField] private float _pointsAmount = 20f;

        private PointsCounter _pointsCounter;

        private CameraShake _cameraShake;

        private CameraController _cameraController;

        private void Awake()
        {
            
        }

        private void Start()
        {
            _cameraShake = FindObjectOfType<CameraShake>();
            Action();
            //var reference = new Reference();
            _pointsCounter = FindObjectOfType<PointsCounter>();
            
        }
        public override void Execute()
        {
          
            Rotate();
        }

        public override void Interraction()
        {
            
            MyEventOnPointChange?.Invoke();
            //ShowAndCountPoints();
            //ShakeCamera();
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.one * (Time.deltaTime * _rotationSpeed), Space.World);
        }

        public void ShowAndCountPoints()

        {
           
            _pointsCounter.GetPoints(_pointsAmount);
            //_displayBonuses.Display(_pointsCounter.Totalpoints);
        }
        
        //public void ShakeCamera()
        //{
        //    _cameraShake.Shake();
        //}
    }
}


    
    


    

