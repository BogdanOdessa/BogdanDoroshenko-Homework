using Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/InteractiveObjects/GetPoints.cs
=======
namespace Game
{
    public delegate void MyDelegate();
    public sealed class PointsReceiver : InteractiveObject, IRotation
    {

        public event MyDelegate MyEventOnPointChange;
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/InteractiveObjects/PointsReceiver.cs

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

<<<<<<< Updated upstream:Bogdan_Unity_OOP/Assets/Scripts/InteractiveObjects/GetPoints.cs
    private void Start()
    {
        _pointsCounter = FindObjectOfType<PointsCounter>().GetComponent<PointsCounter>();
        Action();
    }
=======
        private void Start()
        {
            _cameraShake = FindObjectOfType<CameraShake>();
            Action();
            //var reference = new Reference();
            _pointsCounter = FindObjectOfType<PointsCounter>();
            
        }
        public override void Execute()
        {
            if (this != null)
                Rotate();
        }
>>>>>>> Stashed changes:Bogdan_Unity_OOP/Assets/Scripts/InteractiveObjects/PointsReceiver.cs

    public override void Interraction()
        {
        _pointsCounter.GetPoints(_pointsAmount);
        _displayBonuses.Display(_pointsCounter.Totalpoints);
    }

    public void Rotate()
        {
            if (this != null)
            transform.Rotate(Vector3.one * (Time.deltaTime * _rotationSpeed), Space.World);
        }

        private void Update()
        {
            Rotate();
        }
    }

    
    


    

