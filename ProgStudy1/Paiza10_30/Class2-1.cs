using System;

namespace Paiaza10_30;
class Class2_1
{
    static void Main()
    {
        var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var ans = 0;
        for (var i = 0; i < n[0]; i++)
        {
            ans += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(ans < n[1] ? "Yes" : "No");
    }
}