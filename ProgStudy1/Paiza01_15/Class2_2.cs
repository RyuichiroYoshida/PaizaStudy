using System;
using System.Collections.Generic;

namespace ProgStudy1.Paiza01_15;
public class Class2_2
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
                var lastIndex = list.Count - 1;
                Console.WriteLine(list[lastIndex]);
                list.RemoveAt(lastIndex);
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