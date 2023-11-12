using System;

namespace Paiaza11_13;
class Class2
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == nums.Length - 1)
                    Console.WriteLine($"{nums[i] * nums[j]}");
                else
                    Console.Write($"{nums[i] * nums[j]} ");
            }
        }
    }
}