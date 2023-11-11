using System;

namespace Paiaza11_13;
class Class2_3
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(nums[1] / nums[0]);
    }
}