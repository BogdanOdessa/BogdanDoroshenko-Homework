using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game {
    public sealed class GameController : MonoBehaviour, IDisposable
    {

        public DisplayText _finishGameLabel;

        [SerializeField] private InteractiveObject[] _interactiveObjects;

        private Player _player;
        //private PointsCounter _pointsCounter;

        //private Clone _clone;

        private void Start()
{

            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
            _finishGameLabel = new DisplayText();
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            //_pointsCounter = FindObjectOfType<PointsCounter>().GetComponent<PointsCounter>();
            //_clone = FindObjectOfType<Clone>().GetComponent<Clone>();

            foreach (var item in _interactiveObjects)
            {
                if (item is Trap trap)
                { trap.CaughtPlayer += _player.Die;
                    trap.CaughtPlayer += _finishGameLabel.GameOver;

                    //trap.CaughtPlayer += (sender, color) =>
                    //{
                    //    Debug.LogWarning($"Вы проиграли. Вас убил {sender.GetType()} {color} цвета");
                    //};
                    //trap.CaughtPlayer += _displayEndGame.GameOver;
                }

                if (item is SpeedBonus speedBonus)
                {
                    speedBonus.ActionEvent += _player.GetBonus;
                    speedBonus.ActionEvent += _player.SpeedIncrease;
                    speedBonus.ActionEvent += _player.ChangeColorToGoodEffect;

                }

                if (item is GetPoints getPoints)
                {
                    getPoints.MyEvent += getPoints.ShowAndCountPoints;
                    getPoints.MyEvent += getPoints.ShakeCamera;
                    
                }
                if (item is SpeedDecrease speedDecrease)
                {
                    speedDecrease.myDelegate += _player.GetBonus;
                    speedDecrease.myDelegate += _player.SpeedDecrease;
                    speedDecrease.myDelegate += _player.ChangeColorToBadEffect;
                }
            }
        }

        //private void CaughtPlayer()
        //{
        //    Time.timeScale = 0.5f;
        //}

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

                //Dispose();
            }

            Dispose();
        }
        public void Dispose()
        {

            foreach (var o in _interactiveObjects)
            {
                if (o != null)
                {
                    if (!o.gameObject.activeInHierarchy)
                    {
                        if (o is Trap trap)
                        {
                            trap.CaughtPlayer -= _player.Die;
                            trap.CaughtPlayer -= _finishGameLabel.GameOver;
                        }
                        else if (o is SpeedBonus speedBonus)
                        {
                            speedBonus.ActionEvent -= _player.GetBonus;
                            speedBonus.ActionEvent -= _player.SpeedIncrease;
                            speedBonus.ActionEvent -= _player.ChangeColorToGoodEffect;
                        }

                        else if (o is GetPoints getPoints)
                        {
                            getPoints.MyEvent -= getPoints.ShowAndCountPoints;
                            getPoints.MyEvent -= getPoints.ShakeCamera;

                        }

                        else if (o is SpeedDecrease speedDecrease)
                        {
                            speedDecrease.myDelegate -= _player.GetBonus;
                            speedDecrease.myDelegate -= _player.SpeedDecrease;
                            speedDecrease.myDelegate -= _player.ChangeColorToBadEffect;
                        }
                        Destroy(o.gameObject);
                    }
                }
                   
                
            }
               

                //else continue;


            }
        }

    }

    
    


