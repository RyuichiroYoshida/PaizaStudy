using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class1_7
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
        var point = int.Parse(Console.ReadLine());
        foreach (var item in dic)
        {
            if (item.Value >= point)
                Console.WriteLine(item.Key);
        }
    }
}