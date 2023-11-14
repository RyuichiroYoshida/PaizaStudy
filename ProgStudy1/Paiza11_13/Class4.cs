using System;

namespace Paiaza11_13;
class Class4
{
    static void Main()
    {
        var count = 0;
        var n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i += 2)
        {
            for (int j = i; j % 2 == 0; count++)
                j /= 2;
        }
        Console.WriteLine(count);
    }
}