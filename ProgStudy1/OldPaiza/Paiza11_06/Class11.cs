using System;
using System.Linq;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class11
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (var i = 1; i <= num; i++)
        {
            nums[i - 1] += i;
        }
        Console.WriteLine(nums.Max());
    }
}