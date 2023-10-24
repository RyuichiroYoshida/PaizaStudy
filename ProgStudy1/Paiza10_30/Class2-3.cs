using System;

namespace Paiaza10_30;
class Class2_3
{
    static void Main()
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            var point = int.Parse(Console.ReadLine());
            if (point < min)
                min = point;
            if (point > max)
                max = point;
        }
        Console.WriteLine(max - min);
    }
}