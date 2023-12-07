using System;

namespace ProgStudy1.Paiza12_11;
public class Class1_3
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(nums);
        Console.WriteLine(nums[2] - nums[0]);
    }
}