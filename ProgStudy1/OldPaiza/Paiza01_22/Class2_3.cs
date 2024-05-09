using System;

namespace ProgStudy1.OldPaiza.Paiza01_22;
public class Class2_3
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        var x = nums[0];
        var y = nums[1];
        Console.WriteLine(x * y / GCD(x, y));
    }
    static double GCD(double a, double b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }
}