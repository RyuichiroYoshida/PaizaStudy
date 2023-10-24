using System;

namespace Paiaza10_30;
class Class2_4
{
    static void Main()
    {
        var nums = new int[5];
        for (int i = 0; i < 5; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(nums);
        Console.WriteLine(nums[2]);
    }
}