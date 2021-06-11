using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public sealed class InputController : IExecute
    {

        private PlayerBase _playerBase;

        public InputController(PlayerBase playerBase)
        {
            _playerBase = playerBase;
        }

        public void Execute()
        {
            if (_playerBase != null)
            _playerBase.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        }
    }

}
