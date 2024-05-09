using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza10_30;
class Class5
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        var ans = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        list.Insert(ans[0], ans[1]);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}