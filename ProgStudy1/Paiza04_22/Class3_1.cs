using System;
using System.Linq;

namespace ProgStudy1.Paiza04_22;
public class Class3_1
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        bool[] arr = Enumerable.Repeat(true, num).ToArray();

        arr[0] = arr[1] = false;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (arr[i] == true)
            {
                for (int j = i + i; j <= num; j += i)
                {
                    arr[j] = false;
                }
            }
        }

        var value = new int[2];
        var max = int.MinValue;
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == false) continue;
            for (var j = 0; j < arr.Length; j++)
            {
                if (arr[j] == false || num == i + j) continue;
                if (max < i * j)
                {
                    max = i * j;
                    value[0] = i;
                    value[1] = j;
                }
            }
        }
        Console.WriteLine(value.Min());
        Console.WriteLine(value.Max());
    }
}