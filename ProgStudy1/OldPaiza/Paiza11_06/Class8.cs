using System;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class8
{
    static void Main()
    {
        var count = 0;
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (; nums[0] <= nums[1]; nums[0] += nums[0] / 10)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}