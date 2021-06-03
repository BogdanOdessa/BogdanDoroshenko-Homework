using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PointsCounter : MonoBehaviour
    {
        public float Totalpoints { get; private set; }


        public float GetPoints(float pointsAmount)
        {
            return Totalpoints += pointsAmount;
        }
    }
}
    
    



