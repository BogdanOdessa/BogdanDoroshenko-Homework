using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game
{
    public sealed class Trap : InteractiveObject, IFlay
    {
        public delegate void CaughtPlayerChange(object value);

        //public event CaughtPlayerChange CaughtPlayer;

        private event EventHandler<Color> _caughtPlayer;
        public event EventHandler<Color> CaughtPlayer
        {
            add { _caughtPlayer += value; }
            remove { _caughtPlayer -= value; }
        }

        //private Player _player;
        private float _lengthFlay;
        private Material _material;

        private void Start()
        {
            _lengthFlay = Random.Range(2f, 4f);
            _material = GetComponent<Renderer>().material;
            //_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            Action();
        }

        public override void Action()
        {
            _material.color = Color.red;
            _color = _material.color;

        }
        public void Flay()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _lengthFlay), transform.position.z);
        }

        public override void Interraction()
        {
            _caughtPlayer?.Invoke(this, _color);
            //_player.Die();
        }

        //private void Update()
        //{
        //    Flay();
        //}
    }
}


    
    


