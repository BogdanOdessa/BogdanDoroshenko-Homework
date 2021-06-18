using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Reference
    {
        private Player _player;
        private Camera _mainCamera;
        private Canvas _canvas;
        private GameObject _text;
        private Button _restartButton;

        public Player Player
        {
            get
            {
                //_player = Object.FindObjectOfType<Player>();
                if (_player == null)
                {
                    var gameObject = Resources.Load<Player>("Player");
                    _player = Object.Instantiate(gameObject);
                }
                return _player;
            }
        }

        public Camera Camera
        {
            get
            {
                if (_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
        }

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                   _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
        }

        public GameObject Text
        {
            get
            {
                if (_text == null)
                {
                    var gameObject = Resources.Load<GameObject>("TextObj");
                    _text = Object.Instantiate(gameObject, Canvas.transform);
                }
                return _text;
            }
        }

        public Button RestartButton
        {
            get
            {
                if(_restartButton == null)
                {
                    var gameobJect = Resources.Load<Button>("Restart");
                    _restartButton = Object.Instantiate(gameobJect, Canvas.transform);
                }
                return _restartButton;
            }
        }
    }

}

