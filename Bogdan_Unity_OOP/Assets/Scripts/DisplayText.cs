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
            _text.text = $"Наберите 100 очков для победы";
            //_text = text;
        }

        public void Display(float value)
        {
            //if (value == 0)
            //{
            //    _text.text = $"Наберите 100 очков для победы";
            //}

            if (value > 0 && value < 100)
                _text.text = $"Вы набрали {value} очков";

            else if (value == 100)
            {
                _text.text = "Победа!!!";
                _text.fontSize = 25;
                Time.timeScale = 0.0f;
            }
        }

      

        public void GameOver(object o, Color color)
        {
            _text.text = $"Вы проиграли. Вас убил {o.GetType()} {color} цвета";
            Time.timeScale = 0.0f;

        }

    }
}
    
    


