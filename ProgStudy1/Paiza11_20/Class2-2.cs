using System;

namespace Paiaza11_20;
class Class2_2
{
    static void Main()
    {
        var count = 0;
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < nums[0]; i++)
        {
            if (int.Parse(Console.ReadLine()) >= nums[1])
                count++;
        }
        count -= nums[2];
        if (count < 0)
            Console.WriteLine("0");
        else
            Console.WriteLine(count);
    }
}