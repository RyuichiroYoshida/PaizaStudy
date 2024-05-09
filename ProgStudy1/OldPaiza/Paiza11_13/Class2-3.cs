using System;

namespace ProgStudy1.OldPaiza.Paiza11_13;
class Class2_3
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(nums[1] / nums[0]);
    }
}