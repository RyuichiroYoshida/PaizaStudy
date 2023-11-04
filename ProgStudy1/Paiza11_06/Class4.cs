using System;

namespace Paiaza11_06;
class Class4
{
    static void Main()
    {
        var count = 0;
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        while (nums[0] % nums[1] == 0)
        {
            nums[0] /= nums[1];
            count++;
        }
        Console.WriteLine(count);
    }
}