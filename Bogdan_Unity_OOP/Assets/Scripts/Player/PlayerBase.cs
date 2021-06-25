using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public abstract void Move(float x, float y, float z, float jumpforce);
    }
}

