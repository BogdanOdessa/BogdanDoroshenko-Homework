using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MyException : Exception
    {
        public float Value { get; }

        public MyException(string message, float value) : base(message)
        {
            Value = value;
        }
    }
}

