using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public sealed class SpeedDecrease : InteractiveObject, IFlick
    {

        public MyDelegate myDelegate;

        private Material _material;

        //private Player _player;

        private void Start()
        {
            //_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            _material = GetComponent<Renderer>().material;
        }
        public void Flick()
        {
            _material.color = new Color(Mathf.PingPong(Time.time, 2f), _material.color.r, _material.color.g, _material.color.b);
        }

        public override void Interraction()
        {
            myDelegate?.Invoke();
            //_player.GetBonus();
            //_player.SpeedDecrease();
            //_player.ChangeColorToBadEffect();
        }

        //private void Update()
        //{
        //    Flick();
        //}
    }
}
   
   


