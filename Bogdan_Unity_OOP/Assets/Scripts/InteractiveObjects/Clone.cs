using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Clone : MonoBehaviour
    {
        private void Start()
        {
            FindObjectOfType<SpeedBonus>().Clone();
        }
    }
}

