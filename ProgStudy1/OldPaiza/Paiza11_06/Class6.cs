using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class6
{
    static void Main()
    {
        var ans = new List<int>();
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        while (nums[0] > 0)
        {
            ans.Add(nums[0] % nums[1]);
            nums[0] /= nums[1];
        }
        ans.Reverse();
        foreach (var item in ans)
        {
            Console.Write(item);
        }
    }
}