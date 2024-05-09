using System;
using System.Collections.Generic;
using System.Linq;

public class Class1_6
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var numList = new List<int>();
        for (var i = 0; i < num; i++)
        {
            numList.Add(int.Parse(Console.ReadLine()));
        }
        var maxNum = numList.Max();
        bool[] arr = Enumerable.Repeat(true, maxNum + 1).ToArray();
        arr[0] = arr[1] = false;
        for (int i = 0; i <= maxNum; i++)
        {
            if (arr[i] == true)
            {
                for (int j = i + i; j <= maxNum; j += i)
                {
                    arr[j] = false;
                }
            }
        }

        foreach (var item in numList)
        {
            Console.WriteLine(arr[item] ? "pass" : "failure");
        }
    }
}