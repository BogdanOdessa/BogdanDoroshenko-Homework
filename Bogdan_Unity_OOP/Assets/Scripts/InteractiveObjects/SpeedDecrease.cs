using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

    public class SpeedDecrease : InteractiveObject, IFlick
    {
        private Material _material;

        private Player _player;

        private void Start()
        {
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _material = GetComponent<Renderer>().material;
        }
        public void Flick()
        {
            _material.color = new Color(Mathf.PingPong(Time.time, 2f), _material.color.r, _material.color.g, _material.color.b);
        }

        public override void Interraction()
        {
            _player.GetBonus();
            _player.SpeedDecrease();
        }

        private void Update()
        {
            Flick();
        }
    }
   


