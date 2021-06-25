using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PointsCounter : MonoBehaviour
    {
<<<<<<< Updated upstream
        public float Totalpoints { get; private set; }
=======
        [SerializeField] private float _totalPoints;
        public float Totalpoints { get => _totalPoints; set => _totalPoints = value; }
>>>>>>> Stashed changes


        private void Update()
        {
            if (_totalPoints > 100) throw new MyException("Вы читер! Нельзя набрать больше 100 очков", _totalPoints);
        }

        public float GetPoints(float pointsAmount)
        {
          
            return Totalpoints += pointsAmount;
        }
    }
}
    
    



