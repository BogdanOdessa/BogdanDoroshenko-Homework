using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerRender
    {

        private Player _player;

        private Material _material;
        private Color _initialColor;

        public PlayerRender(Player player)
        {
            _player = player;
            _material = _player.GetComponent<Renderer>().material;
            _initialColor = _player.GetComponent<Renderer>().material.color;
        }

        public void ChangeColorToBadEffect()
        {
            _material.color = Color.yellow; /*Color.Lerp(Color.red, Color.yellow, 10);*/
            _player.SetColor(_material.color);
        }

        public void ColorNomral()
        {
            _material.color = _initialColor;
            _player.SetColor(_material.color);
        }

        public void ChangeColorToGoodEffect()
        {
            _material.color = Color.green;
            _player.SetColor(_material.color);
        }

    }
}

