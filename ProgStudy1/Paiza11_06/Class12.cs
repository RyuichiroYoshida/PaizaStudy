using System;
using System.Linq;

namespace Paiaza11_06;
class Class12
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (var i = 1; i <= num; i++)
        {
            nums[i - 1] += i;
        }
        Console.WriteLine(nums.Min());
    }
}