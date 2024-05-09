using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class5
{
    static void Main()
    {
        var ans = new List<int>();
        var n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            ans.Add(n % 2);
            n /= 2;
        }
        ans.Reverse();
        foreach (var item in ans)
        {
            Console.Write(item);
        }
    }
}