using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgStudy1.Paiza04_22;
public class Class2_3
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var nums = new int[n];
        for (var i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        var min = nums.Min();
        var dic = new Dictionary<int, int>();
        for (var i = 2; i <= min; i++)
        {
            dic.Add(i, int.MaxValue);
        }

        for (var i = 0;i < n; i++)
        {
            for (var j = 2; j <= min; j++)
            {
                var count = 0;
                while (nums[i] % j == 0)
                {
                    nums[i] /= j;
                    count++;
                }

                if (dic[j] > count)
                {
                    dic[j] = count;
                }
            }
        }

        var ans = 1d;
        foreach (var item in dic)
        {
            ans *= Math.Pow(item.Key, item.Value);
        }

        Console.WriteLine(ans);
    }
}