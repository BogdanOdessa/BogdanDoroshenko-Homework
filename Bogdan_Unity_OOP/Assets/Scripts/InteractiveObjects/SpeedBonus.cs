using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Game
{
    public sealed class SpeedBonus : InteractiveObject, IFlick, ICloneable
    {
        public event Action ActionEventSpeedBonus = delegate { };

        private Material _material;

        private float _flickIntensivity;

        [SerializeField] Transform spawnClonePosition;

        private void Start()
        {
            _material = GetComponent<Renderer>().material;
            _flickIntensivity = Random.Range(1f, 3f);

        }
        public void Flick()
        {
            _material.color = new Color(Mathf.PingPong(Time.time, _flickIntensivity), _material.color.r, _material.color.g, _material.color.b);
        }

        public override void Interraction()
        {
            ActionEventSpeedBonus.Invoke();
            //_player.GetBonus(); 
            //_player.SpeedIncrease();
        }

        public object Clone()
        {
            var result = Instantiate(gameObject, spawnClonePosition.position, transform.rotation, transform.parent);

            return result;
        }

        public override void Execute()
        {
            Flick();
        }

    }
}



