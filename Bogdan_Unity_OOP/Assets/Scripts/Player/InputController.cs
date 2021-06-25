using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public sealed class InputController : IExecute
    {

        private PlayerBase _playerBase;
        private SaveDataRepository _saveDataRepository;
        private readonly KeyCode _savePlayer = KeyCode.C;
        private readonly KeyCode _loadPlayer = KeyCode.L;
        private PhotoController _photoController;
        private readonly string _horizontalMove = "Horizontal";
        private readonly string _verticalMove = "Vertical";

        private float _jumpForce;

        public InputController(PlayerBase playerBase)
        {
            _playerBase = playerBase;
            _saveDataRepository = new SaveDataRepository();
        }

        public void Execute()
        {
            if (_playerBase != null)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _jumpForce = 200f;
                }
                else
                {
                    _jumpForce = 0f;
                }

                _playerBase.Move(Input.GetAxis(_horizontalMove), 0.0f, Input.GetAxis(_verticalMove), _jumpForce);
            }

            if (Input.GetKeyDown(_savePlayer))
            {
                _saveDataRepository.Save(_playerBase);
            }

            if (Input.GetKeyDown(_loadPlayer))
            {
                _saveDataRepository.Load(_playerBase);
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                _photoController = new PhotoController();
                _photoController.FirstMethod();
            }

        }

        

    }
}
