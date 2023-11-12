using System;

namespace Paiaza11_13;
class Class3
{
    static void Main()
    {
        var count = 2;
        var n = int.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine(0);
            return;
        }
        if (n <= 2)
        {
            Console.WriteLine(1);
        }
        if (n <= 3)
            Console.WriteLine(2);
        else
        {
            for (int i = 3; i < n; i++)
            {
                for (int j = 3; j <= Math.Sqrt(i); j += 2)
                {
                    if (i % j != 0)
                        continue;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}