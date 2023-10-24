using System;

namespace Paiaza10_30;
class Class2_2
{
    static void Main()
    {
        var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(Math.Abs(n[0] + Math.Abs(n[1])));
    }
}