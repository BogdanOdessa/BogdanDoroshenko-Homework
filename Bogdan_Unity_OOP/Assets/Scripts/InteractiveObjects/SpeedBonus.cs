using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Game
{
    public sealed class SpeedBonus : InteractiveObject, IFlick, ICloneable
    {

        public event Action ActionEvent = delegate { };

        private Material _material;

        //private Player _player;

        private float _flickIntensivity;


        [SerializeField] Transform spawnClonePosition;

        private void Start()
        {
            _material = GetComponent<Renderer>().material;
            //_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _flickIntensivity = Random.Range(1f, 3f);
        }
        public void Flick()
        {
            _material.color = new Color(Mathf.PingPong(Time.time, _flickIntensivity), _material.color.r, _material.color.g, _material.color.b);
        }

        public override void Interraction()
        {
            ActionEvent.Invoke();

            //_player.GetBonus(); 
            //_player.SpeedIncrease();
        }

        public object Clone()
        {
            var result = Instantiate(gameObject, spawnClonePosition.position, transform.rotation, transform.parent);

            return result;
        }

        //private void Update()
        //{
        //    Flick();
        //}
    }
}



