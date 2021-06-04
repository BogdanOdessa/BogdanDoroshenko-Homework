using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class DisplayText
    {
        private Text _text;
        public DisplayText()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(float value)
        {
            if (value < 100)
                _text.text = $"�� ������� {value} �����";
            else _text.text = "������!";
        }

        public void GameOver(object o, Color color)
        {
            _text.text = $"�� ���������. ��� ���� {o.GetType()} {color} �����";

        }

    }
}
    
    


