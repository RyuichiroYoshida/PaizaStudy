using System;

namespace Paiaza11_06;
class Class7
{
    static void Main()
    {
        var count = 0;
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (; nums[0] <= nums[2]; nums[0] += nums[1])
        {
            count++;
        }
        Console.WriteLine(count);
    }
}