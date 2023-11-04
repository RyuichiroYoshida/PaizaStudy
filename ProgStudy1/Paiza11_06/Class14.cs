using System;

namespace Paiaza11_06;
class Class14
{
    static void Main()
    {
        var count = 0;
        var n = int.Parse(Console.ReadLine());
        for (var i = 1; i <= n; i++)
        {
            if (n % i == 0)
                count++;
        }
        Console.WriteLine(count);
    }
}