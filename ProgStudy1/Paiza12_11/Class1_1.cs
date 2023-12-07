using System;

namespace ProgStudy1.Paiza12_11;
public class Class1_1
{
    static void Main()
    {
        var nums = Console.ReadLine().Split();
        Console.WriteLine(Console.ReadLine().Split()[int.Parse(nums[1]) - 1]);
    }
}