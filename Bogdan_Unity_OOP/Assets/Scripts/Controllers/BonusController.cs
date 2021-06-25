using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

namespace Game
{
    public class BonusController : IBonus, IExecute
    {
    
        private bool _isBonusPicked = false;
        private readonly float _timeForBonus = 5f;
        private float _bonusTime;
        private Player _player;
        private PlayerSpeed _playerSpeed;
        private PlayerRender _playerRender;

        public BonusController(PlayerSpeed playerSpeed, PlayerRender playerRender)
        {
            _playerSpeed = playerSpeed;
            _playerRender = playerRender;
            _bonusTime = _timeForBonus;
        }
    
        public void InitiateBonusTimer()
        {
            _bonusTime -= Time.deltaTime;
            if (_bonusTime < 0f)
            {
                _playerSpeed.SpeedNormal();
                _playerRender.ColorNomral();
                //_player.ColorNomral();
                // SpeedNormal();
                // ColorNomral();
                _bonusTime = _timeForBonus;
                _isBonusPicked = false;
            }
        }

        public void GetBonus()
        {
            _isBonusPicked = true;
        }

        public void Execute()
        {
            if (_isBonusPicked)
            {
                InitiateBonusTimer();
            }
        }
    }
}

