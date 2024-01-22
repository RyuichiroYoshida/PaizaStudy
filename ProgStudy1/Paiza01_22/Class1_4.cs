using System;
using System.Collections.Generic;

namespace ProgStudy1.Paiza01_22;
public class Class1_4
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var rateList = new List<int>();
        var maxMoney = 0;
        var minIndex = 0;
        var maxindex = 0;
        for (int i = 0; i < n; i++)
        {
            rateList.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (maxMoney < rateList[j] - rateList[i])
                {
                    maxMoney = rateList[j] - rateList[i];
                    minIndex = i;
                    maxindex = j;
                }
            }
        }
        if (maxindex == minIndex)
        {
            Console.WriteLine("No");
            return;
        }
        Console.WriteLine($"{minIndex + 1}\n{maxindex + 1}");
    }
}