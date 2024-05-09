using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgStudy1.OldPaiza.Paiza01_22;
public class Class1_7
{
    static void Main()
    {
        var workTimeDic = new SortedDictionary<int, int>();
        var taskCount = 0;
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            workTimeDic.Add(nums[1], nums[0]);
        }
        var checkKey = workTimeDic.First().Key;
        foreach (var item in workTimeDic)
        {
            if (checkKey <= item.Value)
            {
                taskCount++;
                checkKey = item.Key;
            }
        }
        Console.WriteLine(taskCount);
    }
}