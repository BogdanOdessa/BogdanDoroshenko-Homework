using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class ExtensionMethods 
{
    public static T AddTo<T>(this T self, ICollection<T> coll)
    {
        coll.Add(self);
        return self;
    }

    public static int CountChar(this string str )
    {
        int count = 0;
        foreach (var item in str)
        {
            count++;
        }
        return count;
    }

    public static Dictionary<int, int> CountSimilarNumbersInList(this List<int> numbers)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            if (keyValuePairs.ContainsKey(number))
            {
                keyValuePairs[number] = keyValuePairs[number] + 1;
            }
            else
            {
                keyValuePairs[number] = 1;
            }
        }
        return keyValuePairs;
    }

    public static string ConvertListOfGenericsToString<T>(this List<T> list)
    {
        string result = "";

        foreach (var item in list)
        {
            result = result + item.ToString() + " ";
        }

        return result;
    }

    public static Dictionary<T, int> CountSimilarValuesInGenericList<T>(this List<T> genericList)
    {
        Dictionary<T, int> keyValuePairs = new Dictionary<T, int>();

        foreach (var value in genericList)
        {
            if (keyValuePairs.ContainsKey(value))
            {
                keyValuePairs[value] = keyValuePairs[value] + 1;
            }
            else
            {
                keyValuePairs[value] = 1;
            }
        }
        return keyValuePairs;
    }

    public static void PrintDictionary<T>(this Dictionary<T, T> digtionary)
    {

        foreach (KeyValuePair<T, T> user in digtionary)
        {
            Debug.Log($"Значение {user.Key} встречается {user.Value} раз(а)");
        }
       
    }

}
