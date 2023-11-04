using System;

namespace Paiaza11_06;
class Class2
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (var i = 1; i <= num; i++)
        {
            Console.WriteLine(nums[i - 1] * i);
        }
    }
}