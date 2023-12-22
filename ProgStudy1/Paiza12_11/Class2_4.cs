using System;
using System.Linq;

namespace ProgStudy1.Paiza12_11;
public class Class2_4
{
    static void Main()
    {
        var maxSum = int.MinValue;
        var ansNum = 0;
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (nums[0] == nums[1])
        {
            Console.WriteLine(1);
            return;
        }
        for (int i = 0; i < nums[0] - (nums[1] - 1); i++)
        {
            var sum = arr.Skip(i).Take(nums[1]).Sum();
            if (sum >= maxSum)
            {
                maxSum = sum;
                ansNum = i;
            }
        }
        Console.WriteLine(ansNum + 1);
    }
}