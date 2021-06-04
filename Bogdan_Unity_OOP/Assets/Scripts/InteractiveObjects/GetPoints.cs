
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public delegate void MyDelegate();
    public sealed class GetPoints : InteractiveObject, IRotation
    {

        public event MyDelegate MyEvent;


        private DisplayText _displayBonuses;

        private float _rotationSpeed = 20f;

        //public float Points { get; private set; } = 20f;
        [SerializeField] private float _pointsAmount = 20f;

        private PointsCounter _pointsCounter;

        private CameraShake _cameraShake;

        private void Awake()
        {
            _displayBonuses = new DisplayText();
        }

        private void Start()
        {
            _pointsCounter = FindObjectOfType<PointsCounter>().GetComponent<PointsCounter>();
            _cameraShake = FindObjectOfType<CameraShake>().GetComponent<CameraShake>();
            Action();
        }

        public override void Interraction()
        {
            MyEvent?.Invoke();
            //ShowAndCountPoints();
            //ShakeCamera();
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.one * (Time.deltaTime * _rotationSpeed), Space.World);
        }

        //private void Update()
        //{
        //    Rotate();
        //}

        public void ShowAndCountPoints()
        {
            _pointsCounter.GetPoints(_pointsAmount);
            _displayBonuses.Display(_pointsCounter.Totalpoints);
        }
        
        public void ShakeCamera()
        {
            _cameraShake.Shake();
        }
    }
}


    
    


    

