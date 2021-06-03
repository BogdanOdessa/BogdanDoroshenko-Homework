using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;
using System;

public class SpeedBonus : InteractiveObject, IFlick, ICloneable
    {
        private Material _material;

        private Player _player;

    [SerializeField] Transform spawnClonePosition;

        private void Start()
        {
            _material = GetComponent<Renderer>().material;
            _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
        public void Flick()
        {
            _material.color = new Color(Mathf.PingPong(Time.time, 2f), _material.color.r, _material.color.g, _material.color.b);
        }

        public override void Interraction()
        {
            _player.GetBonus();
            _player.SpeedIncrease();
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


