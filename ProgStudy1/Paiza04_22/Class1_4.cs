using System;
using System.Linq;

namespace ProgStudy1.Paiza04_22;
public class Class1_4
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());

        if (num < 2)
        {
            Console.WriteLine("NO");
            return;
        }
        else if (num < 3)
        {
            Console.WriteLine("YES");
            return;
        }

        bool[] arr = Enumerable.Repeat(true, num + 1).ToArray();

        arr[0] = arr[1] = false;
        for (int i = 0; i <= num; i++)
        {
            if (arr[i] == true)
            {
                for (int j = i + i; j <= num; j += i)
                {
                    arr[j] = false;
                }
            }
        }

        Console.WriteLine(arr[arr.Length] ? "YES" : "NO");
    }
}