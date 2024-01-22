using System;

namespace ProgStudy1.Paiza01_22;
public class Class2_5
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = 0, y = 0;
        EctGCD(nums[0], nums[1], ref x, ref y);
        Console.WriteLine($"{x} {y}");
    }
    static void EctGCD(int a, int b, ref int x, ref int y)
    {
        if (b != 0)
        {
            EctGCD(b, a % b, ref y,ref x);
            y -= (a / b) * x;
        }
        else
        {
            x = 1;
            y = 0;
        }
    }
}