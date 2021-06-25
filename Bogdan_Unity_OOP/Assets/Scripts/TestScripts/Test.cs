using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Test : MonoBehaviour
{
    private void Start()
    {



        var list = new List<int>();
        var list2 = new List<int>();

        list.Add(2);

        1.AddTo(list).AddTo(list2);

      


    }

    //public static class ExtMethod
    //{
      
    //}

    //public static T AddTo<T>(this T self, ICollection<T> coll)
    //{
    //    coll.Add(self);
    //    return self;
    //}

    private ICollection<T> GetUniques<T>(ICollection<T> list)
    {
        // Для отслеживания элементов используйте словарь 
        Dictionary<T, bool> found = new Dictionary<T, bool>();
        List<T> uniques = new List<T>();
        // Этот алгоритм сохраняет оригинальный порядок элементов 
        foreach (T val in list)
        {
            if (!found.ContainsKey(val))
            {
                found[val] = true;
                uniques.Add(val);
            }
        }
        return uniques;
    }

   
    




    public void Main()
        {
            #region ExampleDictionary

            var dict = new Dictionary<char, string>();

            dict.Add('r', "Roman");
            dict.Add('i', "Iva");
            dict.Add('v', "Viktor");

            // Перебор коллекции
            foreach (KeyValuePair<char, string> user in dict)
            {
                Debug.Log($"{user.Key} - {user.Value}");
            }

            dict['i'] = "Roman"; // Изменяем элемент с ключом i
            dict['t'] = "Roman"; // Добавляем элемент с ключом t


            foreach (KeyValuePair<char, string> user in dict)
            {
                Debug.Log($"{user.Key} - {user.Value}");
            }

            dict.Remove('i'); // Удаляем элемент по ключу

            if (dict.ContainsKey('i')) // Проверяем, имеется ли элемент с ключом i
            {
                var tempUser = dict['i']; // Получаем элемент по ключу i
            }

            // Перебор ключей
            foreach (var user in dict.Keys)
            {
                Debug.Log($"{user}");
            }

            // Перебор по значениям
            foreach (var p in dict.Values)
            {
                Debug.Log(p);
            }


            #endregion

            #region C# 5

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                {1,"Roman" },
                {2,"Ivan" },
                {3,"Igor" },
                {4,"Vova" }
            };

            #endregion

            #region C# 6

            Dictionary<int, string> dictionary2 = new Dictionary<int, string>
            {
                [1] = "Roman",
                [2] = "Roman",
                [3] = "Roman",
                [4] = "Roman"
            };

            #endregion
        }
}
