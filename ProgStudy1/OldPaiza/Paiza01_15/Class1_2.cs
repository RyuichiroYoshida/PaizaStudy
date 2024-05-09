using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza01_15;
public class Class1_2
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<string>();
        for (int i = 0; i < n; i++)
        {
            var order = Console.ReadLine().Split();
            if (order[0] == "1")
            {
                list.Add(order[1]);
            }
        }
        Console.WriteLine(list.Count);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}