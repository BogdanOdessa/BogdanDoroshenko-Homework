using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;
using System;

public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }
        // ћожем дописать сколько угодно свойств
        public CaughtPlayerEventArgs(Color Color)
        {
            this.Color = Color;
        }

    }


