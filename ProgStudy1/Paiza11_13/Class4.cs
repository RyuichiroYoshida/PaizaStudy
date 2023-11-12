using System;

namespace Paiaza11_13;
class Class4
{
    static void Main()
    {
        var count = 0;
        var n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            n *= i;
        }
        while (n >= 0)
        {
            n /= 2;
            count++;
        }
        Console.WriteLine(count);
    }
}