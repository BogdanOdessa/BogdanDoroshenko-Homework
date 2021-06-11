using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game
{
    public sealed class GameController : MonoBehaviour, IDisposable
    {
        public DisplayText _GameText;

        [SerializeField] private InteractiveObject[] _interactiveObjects;

        private Player _player;

        private ListExecuteObject _interactiveObject;

        private CameraController _cameraController;

        private InputController _inputController;

        public PlayerType playerType = PlayerType.Ball;

        private PointsCounter _pointsCounter;

        private Reference _reference;

        private SpeedControl _speedControl;


        private void Awake()
        {

        }


        private void Start()
        {

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

            foreach (var item in _interactiveObject)
            {
                if (item is SpeedControl speedControl)
                {

                }
                if (item is Trap trap)
                {
                    trap.CaughtPlayer += _player.Die;
                    trap.CaughtPlayer += _GameText.GameOver;
                }

                if (item is SpeedBonus speedBonus)
                {
                    speedBonus.ActionEventSpeedBonus += _player.GetBonus;
                    speedBonus.ActionEventSpeedBonus += _player.SpeedIncrease;
                    speedBonus.ActionEventSpeedBonus += _player.ChangeColorToGoodEffect;

                }

                if (item is GetPoints getPoints)
                {
                    getPoints.MyEventOnPointChange += getPoints.ShowAndCountPoints;
                    //getPoints.MyEventOnPointChange += getPoints.ShakeCamera;
                    getPoints.MyEventOnPointChange += _cameraController.Shake;

                }
                if (item is SpeedDecrease speedDecrease)
                {
                    speedDecrease.myDelegateSpeedIncrease += _player.GetBonus;
                    speedDecrease.myDelegateSpeedIncrease += _player.SpeedDecrease;
                    speedDecrease.myDelegateSpeedIncrease += _player.ChangeColorToBadEffect;
                }
            }
        }
        private void Update()
        {

            for (int i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                interactiveObject.Execute();
            }

            if(_player != null)
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
                        trap.CaughtPlayer -= _player.Die;
                        trap.CaughtPlayer -= _GameText.GameOver;
                    }
                    else if (o is SpeedBonus speedBonus)
                    {
                        speedBonus.ActionEventSpeedBonus -= _player.GetBonus;
                        speedBonus.ActionEventSpeedBonus -= _player.SpeedIncrease;
                        speedBonus.ActionEventSpeedBonus -= _player.ChangeColorToGoodEffect;
                    }

                    else if (o is GetPoints getPoints)
                    {
                        getPoints.MyEventOnPointChange -= getPoints.ShowAndCountPoints;
                        //getPoints.MyEventOnPointChange -= getPoints.ShakeCamera;
                    getPoints.MyEventOnPointChange -= _cameraController.Shake;

                }

                    else if (o is SpeedDecrease speedDecrease)
                    {
                        speedDecrease.myDelegateSpeedIncrease -= _player.GetBonus;
                        speedDecrease.myDelegateSpeedIncrease -= _player.SpeedDecrease;
                        speedDecrease.myDelegateSpeedIncrease -= _player.ChangeColorToBadEffect;
                    }                               
                       
            }
        }

    }
}
//foreach (var o in _interactiveObjects)
//{
//    if (o != null)
//    {
//        if (!o.gameObject.activeInHierarchy)
//        {
//            if (o is Trap trap)
//            {
//                trap.CaughtPlayer -= _player.Die;
//                trap.CaughtPlayer -= _finishGameLabel.GameOver;
//            }
//            else if (o is SpeedBonus speedBonus)
//            {
//                speedBonus.ActionEventSpeedBonus -= _player.GetBonus;
//                speedBonus.ActionEventSpeedBonus -= _player.SpeedIncrease;
//                speedBonus.ActionEventSpeedBonus -= _player.ChangeColorToGoodEffect;
//            }

//            else if (o is GetPoints getPoints)
//            {
//                getPoints.MyEventOnPointChange -= getPoints.ShowAndCountPoints;
//                getPoints.MyEventOnPointChange -= getPoints.ShakeCamera;

//            }

//            else if (o is SpeedDecrease speedDecrease)
//            {
//                speedDecrease.myDelegateSpeedIncrease -= _player.GetBonus;
//                speedDecrease.myDelegateSpeedIncrease -= _player.SpeedDecrease;
//                speedDecrease.myDelegateSpeedIncrease -= _player.ChangeColorToBadEffect;
//            }
//            Destroy(o.gameObject);
//        }
//    }

//}










