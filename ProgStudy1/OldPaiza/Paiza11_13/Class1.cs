using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza11_13;
class Class1
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var lines = new List<string[]>();
        for (int i = 0; i < nums[0]; i++)
        {
            lines.Add(Console.ReadLine().Split());
        }
        for (int i = 0; i < nums[1]; i++)
        {
            for (int j = 0; j < nums[0]; j++)
            {
                if (j == nums[0] - 1)
                    Console.WriteLine(lines[j][i]);
                else
                    Console.Write($"{lines[j][i]} ");
            }
        }
    }
}