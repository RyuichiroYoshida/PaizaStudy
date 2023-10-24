using System;

namespace Paiaza10_30;
class Class8
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];
        nums[0] = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(nums[i] * nums[j]);
            }
        }
    }
}