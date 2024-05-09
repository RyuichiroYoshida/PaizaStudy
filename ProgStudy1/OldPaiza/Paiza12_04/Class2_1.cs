using System;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class2_1
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(nums[1] - nums[0]);
    }
}