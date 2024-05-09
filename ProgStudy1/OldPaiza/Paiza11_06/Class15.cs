using System;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class15
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (var i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }
}