using System;

namespace ProgStudy1.Paiza01_22;
public class Class2_4
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (nums[0] % nums[1] == nums[2])
        {
            Console.WriteLine($"1 {-(nums[0] / nums[1])}");
        }
        else
        {
            Console.WriteLine($"{-(nums[1] / nums[1])} 1");
        }
    }
}