using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Homework5 : MonoBehaviour
{
    private void Start()
    {
        Task2();
        Task3Part1();
        Task3Part2();
        Task4Part1();
    }

    private static void Task2()
    {
        string str = "Hello";

        int charCount = str.CountChar();

        Debug.Log($"Кол-во символов в строке {str} равно {charCount}");
    }

    private static void Task3Part1()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 1, 1, 2 };

        string numbersString = numbers.ConvertListOfGenericsToString();

        var numbersCount = numbers.CountSimilarNumbersInList();

        Debug.Log($"Кол-во символов в коллекции {numbersString}");
        foreach (KeyValuePair<int, int> user in numbersCount)
        {
            Debug.Log($"Значение {user.Key} встречается {user.Value} раз(а)");
        }
    }

    private static void Task3Part2()
    {
        List<string> genericStringsList = new List<string>
        {
            "asdasd",
            "asdasd",
            "asdasd",
            "asdd",
            "asd",
            "asdd"
        };

        Debug.Log($"Кол-во символов в коллекции {genericStringsList.ConvertListOfGenericsToString()}");

        foreach (KeyValuePair<string, int> user in genericStringsList.CountSimilarValuesInGenericList())
        {
            Debug.Log($"Значение {user.Key} встречается {user.Value} раз(а)");
        }
    }
    private static void Task4Part1()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"four",4 },
            {"two",2 },
            { "one",1 },
            {"three",3 },
        };

        var d = dict.OrderBy(pair => pair.Value);

        foreach (var pair in d)
        {
            Debug.Log($"{pair.Key} - {pair.Value}");
        }
    }
}
