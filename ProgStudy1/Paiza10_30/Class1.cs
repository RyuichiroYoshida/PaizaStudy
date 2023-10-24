using System;

namespace Paiaza10_30;
class Class1
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(nums);
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}