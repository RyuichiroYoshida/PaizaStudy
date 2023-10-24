using System;

namespace Paiaza10_30;
class Class9
{
    static void Main()
    {
        var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 1; i < n[1] + 1; i++)
        {
            Console.WriteLine(Console.ReadLine() ?? "0");
        }
    }
}