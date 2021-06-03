using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class DisplayBonuses
    {
        private Text _text;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(float value)
        {
            if (value < 100)
                _text.text = $"�� ������� {value} �����";
            else _text.text = "������!";
        }

    }
}
    
    


