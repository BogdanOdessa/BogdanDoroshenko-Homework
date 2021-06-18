using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    internal abstract class SpeedView : MonoBehaviour, IFlick
    {
        public abstract void Flick();
    }
}

