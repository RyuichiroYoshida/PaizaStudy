using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class5
{
    static void Main()
    {
        var flag = false;
        var num = int.Parse(Console.ReadLine());
        var nums = new int[num];
        var ansList = new List<int>();
        var ansStr = "no answer";
        for (int i = 0; i < num; i++)
            nums[i] = int.Parse(Console.ReadLine());
        Array.Sort(nums);
        for (int i = 1; i < 2 << num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                var n = i >> j & 1;
                if (n == 1)
                    ansList.Add(nums[j]);
                if (ansList.Sum() == 777 && !flag)
                {
                    if (flag)
                    {
                        Console.WriteLine("multiple answers");
                        return;
                    }
                    else
                    {
                        ansStr = string.Join(" ", ansList);
                        flag = true;
                    }
                }
            }
        }
        Console.WriteLine(ansStr);
    }
}