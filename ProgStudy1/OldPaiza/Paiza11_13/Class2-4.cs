using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza11_13;
class Class2_4
{
    static void Main()
    {
        var paizaDic = new SortedDictionary<int, string>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var nums = Console.ReadLine().Split();
            paizaDic.Add(int.Parse(nums[0]), nums[1]);
        }
        foreach (var item in paizaDic)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
    }
}