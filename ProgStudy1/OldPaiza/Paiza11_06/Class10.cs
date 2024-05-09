using System;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class10
{
    static void Main()
    {
        var ans = 0;
        var n = Console.ReadLine();
        for (var i = 1; i <= n.Length; i++)
        {
            ans += int.Parse(n) / (int)Math.Pow(5, i);
        }
        Console.WriteLine(ans);
    }
}