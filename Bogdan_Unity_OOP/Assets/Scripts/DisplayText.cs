using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class DisplayText
    {
        private Text _text;

        //public DisplayText()
        //{

        //}

        public DisplayText(GameObject text)
        {
            _text = Object.FindObjectOfType<Text>();
            _text.text = $"�������� 100 ����� ��� ������";
            //_text = text;
        }

        public void Display(float value)
        {
            //if (value == 0)
            //{
            //    _text.text = $"�������� 100 ����� ��� ������";
            //}

            if (value > 0 && value < 100)
                _text.text = $"�� ������� {value} �����";

            else if (value == 100)
            {
                _text.text = "������!!!";
                _text.fontSize = 25;
                Time.timeScale = 0.0f;
            }
        }

      

        public void GameOver(object o, Color color)
        {
            _text.text = $"�� ���������. ��� ���� {o.GetType()} {color} �����";
            Time.timeScale = 0.0f;

        }

    }
}
    
    


