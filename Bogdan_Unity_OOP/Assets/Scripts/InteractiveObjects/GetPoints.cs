using Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class GetPoints : InteractiveObject, IRotation
    {
        private DisplayBonuses _displayBonuses;

        private float _rotationSpeed = 20f;

        //public float Points { get; private set; } = 20f;
        [SerializeField] private float _pointsAmount = 20f;

        private PointsCounter _pointsCounter;

        private void Awake()
        {
            _displayBonuses = new DisplayBonuses();
        }

    private void Start()
    {
        _pointsCounter = FindObjectOfType<PointsCounter>().GetComponent<PointsCounter>();
        Action();
    }

    public override void Interraction()
        {
        _pointsCounter.GetPoints(_pointsAmount);
        _displayBonuses.Display(_pointsCounter.Totalpoints);
    }

    public void Rotate()
        {
            transform.Rotate(Vector3.one * (Time.deltaTime * _rotationSpeed), Space.World);
        }

        private void Update()
        {
            Rotate();
        }
    }

    
    


    

