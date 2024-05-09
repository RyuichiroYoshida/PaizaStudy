using System;

namespace ProgStudy1.Paiza04_22;
public class Class1_3
{
    static void Main()
    {
        var num = double.Parse(Console.ReadLine());

        if (num < 2)
        {
            Console.WriteLine("NO");
            return;
        }
        else if (num <= 3)
        {
            Console.WriteLine("YES");
            return;
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("NO");
            return;
        }

        for (var i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
            {
                Console.WriteLine("NO");
                return;
            }
        }
        Console.WriteLine("YES");
    }
}