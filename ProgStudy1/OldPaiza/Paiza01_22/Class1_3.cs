using System;

namespace ProgStudy1.OldPaiza.Paiza01_22;
public class Class1_3
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
        var sum = nums[0] + nums[1];
        Console.WriteLine(sum.ToString("0.000"));
    }
}