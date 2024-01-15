using System;

namespace ProgStudy1.Paiza01_15;
public class Class4_5
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var mul = nums[0] * nums[1];
        if (mul % 2 == 0)
        {
            Console.WriteLine(mul / 2);
        }
        else
        {
            Console.WriteLine((mul - 1) / 2);
        }
    }
}