using System;
using System.Collections.Generic;

namespace ProgStudy1.Paiza01_22;
public class Class1_7
{
    static void Main()
    {
        var workTimeList = new List<int[]>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            workTimeList[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
        workTimeList.Sort();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

            }
        }
    }
}