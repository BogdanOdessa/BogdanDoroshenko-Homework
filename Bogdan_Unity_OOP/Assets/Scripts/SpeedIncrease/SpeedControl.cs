using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    internal class SpeedControl : SpeedView, IExecute 
    {
        private SpeedModel _speedModel;
        private GameObject _gameObject;
        private Material _material;
        private Player _player;

        public SpeedControl()
        {
            _speedModel = new SpeedModel();
            _gameObject = Object.Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
            _gameObject.transform.position = new Vector3(7, 1, -35);
            _material = _gameObject.GetComponent<Renderer>().material;
            _player = FindObjectOfType<Player>();
        }
        public void Execute()
        {
            Flick();

        }

        public override void Flick()
        {
            
            _material.color = new Color(Mathf.PingPong(Time.time, _speedModel.FlickIntensivity), _material.color.r, _material.color.g, _material.color.b);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interraction();
                Destroy(this);
            }
            
        }

        private void Interraction()
        {
            _player.GetBonus();
            _player.SpeedIncrease();
        }
    }
}

