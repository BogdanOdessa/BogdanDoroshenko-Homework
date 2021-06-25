using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
<<<<<<< Updated upstream
    public class PlayerSpeed : ISpeedChange
    {
        private Player player;


        public void SpeedDecrease()
        {
            throw new System.NotImplementedException();
        }

        public void SpeedIncrease()
        {
            throw new System.NotImplementedException();
=======
    public class PlayerSpeed: ISpeedChange
    {
        public float СurrentSpeed {  get; private set; }
        private readonly float _initialSpeed = 3f;
        private Player _player;

        public PlayerSpeed(Player player)
        {
            СurrentSpeed = _initialSpeed;
            _player = player;
            _player.SetSpeed(СurrentSpeed);
        }
        
        public void SpeedIncrease()
        {
            СurrentSpeed *= 2;
            _player.SetSpeed(СurrentSpeed);

        }

        public void SpeedDecrease()
        {
            СurrentSpeed /= 2;
            _player.SetSpeed(СurrentSpeed);

>>>>>>> Stashed changes
        }

        public void SpeedNormal()
        {
<<<<<<< Updated upstream
            throw new System.NotImplementedException();
        }
    }
}
    


=======
            СurrentSpeed = _initialSpeed;
            _player.SetSpeed(СurrentSpeed);
        }
    }

}
>>>>>>> Stashed changes
