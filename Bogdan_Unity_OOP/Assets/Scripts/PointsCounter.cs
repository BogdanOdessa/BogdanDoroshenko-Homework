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


        public float GetPoints(float pointsAmount)
        {
            return Totalpoints += pointsAmount;
        }
    }
}
    
    



