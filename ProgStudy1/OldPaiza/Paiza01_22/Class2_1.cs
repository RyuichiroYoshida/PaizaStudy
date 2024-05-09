using System;

namespace ProgStudy1.OldPaiza.Paiza01_22;
public class Class2_1
{
    static void Main()
    {
        var num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(GCD(num[0], num[1]));
    }
    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }
}