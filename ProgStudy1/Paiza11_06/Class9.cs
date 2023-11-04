using System;

namespace Paiaza11_06;
class Class9
{
    static void Main()
    {
        var ans = 1;
        var n = int.Parse(Console.ReadLine());
        for (; 0 <= n; n--)
        {
            ans *= n;
        }
        Console.WriteLine(ans);
    }
}