using System;

namespace Paiaza10_30;
class Class11
{
    static void Main()
    {
        var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < n[0]; i++)
        {
            var ans = int.Parse(Console.ReadLine());
            if (n[1] <= ans)
                Console.WriteLine(ans);
        }
    }
}