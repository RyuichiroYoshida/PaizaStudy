using System;

namespace ProgStudy1.Paiza12_04;
public class Class1_3
{
    static void Main()
    {
        var minAns = int.MaxValue;
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var k = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            if (nums[i] >= k)
            {
                if (nums[i] < minAns)
                    minAns = nums[i];
            }
        }
        Console.WriteLine(minAns);
    }
}

