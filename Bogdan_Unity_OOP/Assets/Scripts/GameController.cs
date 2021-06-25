using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public class GameController : MonoBehaviour /*, IDisposable*/
    {
        [SerializeField] private InteractiveObject[] _interactiveObjects;

<<<<<<< Updated upstream
        private void Start()
=======
        private Player _player;

       [SerializeField] private ListExecuteObject _interactiveObject;

        private CameraController _cameraController;

        private InputController _inputController;

        public PlayerType playerType = PlayerType.Ball;

        private PointsCounter _pointsCounter;

        private Reference _reference;

        private SpeedControl _speedControl;

        private BonusController _bonusController;

        private PlayerSpeed _playerSpeed;

        private PlayerRender _playerRender;


        private void Awake()
>>>>>>> Stashed changes
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }

        private void Update()
        {
<<<<<<< Updated upstream
            for (int i = 0; i < _interactiveObjects.Length; i++)
=======

            _interactiveObject = new ListExecuteObject();
            //_interactiveObjects = FindObjectsOfType<InteractiveObject>();
            

            _reference = new Reference();

            _cameraController = new CameraController(_reference.Player.transform,_reference.Camera.transform);
            _interactiveObject.AddExecuteObject(_cameraController);

            _inputController = new InputController(_reference.Player);
            _interactiveObject.AddExecuteObject(_inputController);

            _GameText = new DisplayText(_reference.Text);
            _pointsCounter = GetComponent<PointsCounter>();

            _speedControl = new SpeedControl();
            _interactiveObject.AddExecuteObject(_speedControl);

            

            _reference.RestartButton.onClick.AddListener(Restart);
            //_reference.RestartButton.gameObject.SetActive(false);


            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _playerSpeed = new PlayerSpeed(_player);
            _playerRender = new PlayerRender(_player);

            _bonusController = new BonusController(_playerSpeed, _playerRender);
           
            _interactiveObject.AddExecuteObject((_bonusController));     


            foreach (var item in _interactiveObject)
>>>>>>> Stashed changes
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
<<<<<<< Updated upstream
                    continue;
=======
                    trap._caughtPlayer += _player.Die;
                    trap._caughtPlayer += _GameText.GameOver;
>>>>>>> Stashed changes
                }

                if (interactiveObject is IFlay flay)
                {
<<<<<<< Updated upstream
                    flay.Flay();
                }

                if (interactiveObject is IFlick flick)
                {
                    flick.Flick();
=======
                    speedBonus.ActionEventSpeedBonus += _bonusController.GetBonus;
                    speedBonus.ActionEventSpeedBonus += _playerSpeed.SpeedIncrease;
                    speedBonus.ActionEventSpeedBonus += _playerRender.ChangeColorToGoodEffect;

                }

                if (item is PointsReceiver getPoints)
                {
                    getPoints.MyEventOnPointChange += getPoints.ShowAndCountPoints;
                    //getPoints.MyEventOnPointChange += getPoints.ShakeCamera;
                    getPoints.MyEventOnPointChange += _cameraController.Shake;

                }
                if (item is SpeedDecrease speedDecrease)
                {
                    speedDecrease.myDelegateSpeedIncrease += _bonusController.GetBonus;
                    speedDecrease.myDelegateSpeedIncrease += _playerSpeed.SpeedDecrease;
                    speedDecrease.myDelegateSpeedIncrease += _playerRender.ChangeColorToBadEffect;
>>>>>>> Stashed changes
                }

                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotate();
                }
            }

<<<<<<< Updated upstream
        }
        //public void Dispose()
        //{
        //    foreach (var o in _interactiveObjects)
        //    {
        //        Destroy(o.gameObject);
        //    }
        //}
=======
            //if(_player != null)
            _GameText.Display(_pointsCounter.Totalpoints);

        }

        void Restart()
        {
            Dispose();
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            { 
                    if (o is Trap trap)
                    {
                        trap._caughtPlayer -= _player.Die;
                        trap._caughtPlayer -= _GameText.GameOver;
                    }
                    else if (o is SpeedBonus speedBonus)
                    {
                        speedBonus.ActionEventSpeedBonus -= _bonusController.GetBonus;
                        speedBonus.ActionEventSpeedBonus -= _playerSpeed.SpeedIncrease;
                        speedBonus.ActionEventSpeedBonus -= _playerRender.ChangeColorToGoodEffect;
                    }

                    else if (o is PointsReceiver getPoints)
                    {
                        getPoints.MyEventOnPointChange -= getPoints.ShowAndCountPoints;
                        //getPoints.MyEventOnPointChange -= getPoints.ShakeCamera;
                    getPoints.MyEventOnPointChange -= _cameraController.Shake;

                }

                    else if (o is SpeedDecrease speedDecrease)
                    {
                        speedDecrease.myDelegateSpeedIncrease -= _bonusController.GetBonus;
                        speedDecrease.myDelegateSpeedIncrease -= _playerSpeed.SpeedDecrease;
                        speedDecrease.myDelegateSpeedIncrease -= _playerRender.ChangeColorToBadEffect;
                    }                               
                       
            }
        }

>>>>>>> Stashed changes
    }
}
    
    


