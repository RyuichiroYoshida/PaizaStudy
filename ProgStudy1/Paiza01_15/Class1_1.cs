using System;

namespace ProgStudy1.Paiza01_15;
public class Class1_1
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(n);
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
}