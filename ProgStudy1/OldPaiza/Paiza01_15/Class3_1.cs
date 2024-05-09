using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza01_15;
public class Class3_1
{
    static void Main()
    {
        var list = new List<string>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var order = Console.ReadLine().Split();
            if (order[0] == "1")
            {
                list.Add(order[1]);
            }
            else
            {
                list.RemoveAt(0);
            }
            var str = "";
            foreach (var item in list)
            {
                str += item + " ";
            }
            Console.WriteLine(str.Trim());
        }
    }
}