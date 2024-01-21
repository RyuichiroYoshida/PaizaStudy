using System;

namespace ProgStudy1.Paiza01_22;
public class Class1_4
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var minValue = int.MaxValue;
        var minIndex = 0;
        var maxValue = int.MinValue;
        var maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            var value = int.Parse(Console.ReadLine());
            if (value < minValue)
            {
                minValue = value;
                minIndex = i;
            }
            if (value > maxValue)
            {
                maxValue = value;
                maxIndex = i;
            }
        }
        if (minIndex >= maxIndex)
        {
            Console.WriteLine("No");
            return;
        }
        Console.WriteLine($"{minIndex + 1}\n{maxIndex + 1}");
    }
}