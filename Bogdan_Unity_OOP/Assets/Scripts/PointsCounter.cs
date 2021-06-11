using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PointsCounter : MonoBehaviour
    {
        [SerializeField] private float _totalPoints;
        public float Totalpoints { get => _totalPoints; private set => _totalPoints = value; }


        private void Update()
        {
            if (_totalPoints > 100) throw new MyException("�� �����! ������ ������� ������ 100 �����", _totalPoints);
        }

        public float GetPoints(float pointsAmount)
        {
          
            return Totalpoints += pointsAmount;
        }
    }
}
    
    



