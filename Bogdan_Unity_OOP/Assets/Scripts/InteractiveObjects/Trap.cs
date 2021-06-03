using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

    public class Trap : InteractiveObject, IFlay
    {
        private Player _player;
        private float _lengthFlay;
        private Material _material;

        private void Start()
        {
            _lengthFlay = Random.Range(2f, 4f);
            _material = GetComponent<Renderer>().material;
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            Action();
        }

        public override void Action()
        {
            _material.color = Color.red;

        }
        public void Flay()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _lengthFlay), transform.position.z);
        }

        public override void Interraction()
        {
        _player.Die();
        }

        private void Update()
        {
            Flay();
        }
    }

    
    


