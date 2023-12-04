using System;
using System.Collections.Generic;

namespace ProgStudy1.Paiza12_04;
public class Class1_8
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var dic = new Dictionary<string, int>();
        for (int i = 0; i < num; i++)
        {
            var nums = Console.ReadLine().Split();
            dic.Add(nums[0], int.Parse(nums[1]));
        }
        var points = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        foreach (var item in dic)
        {
            if (item.Value >= points[0] && item.Value <= points[1])
                Console.WriteLine(item.Key);
        }
    }
}