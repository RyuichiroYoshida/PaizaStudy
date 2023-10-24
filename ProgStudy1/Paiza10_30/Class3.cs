using System;

namespace Paiaza10_30;
class Class3
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        var storage = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var str = nums[storage[0] - 1];
        nums[storage[0] - 1] = nums[storage[1] - 1];
        nums[storage[1] - 1] = str;
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}