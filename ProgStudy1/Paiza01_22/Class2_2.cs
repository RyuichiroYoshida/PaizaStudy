using System;

namespace ProgStudy1.Paiza01_22;
public class Class2_2
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            x = GCD(x, int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(x);
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