using System;

namespace ProgStudy1.Paiza01_22;
public class Class1_2
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(nums[0] + (nums[2] - nums[1]));
    }
}