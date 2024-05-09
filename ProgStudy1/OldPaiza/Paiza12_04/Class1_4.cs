using System;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class1_4
{
    static void Main()
    {
        var maxAns = int.MinValue;
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var k = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            if (nums[i] <= k)
            {
                if (nums[i] > maxAns)
                    maxAns = nums[i];
            }
        }
        Console.WriteLine(maxAns);
    }
}

