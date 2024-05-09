using System;
using System.Collections.Generic;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class2_6
{
    static void Main()
    {
        var pinList = new List<int>();
        var pinNum = 10;
        for (int i = 4; 0 < i; i--)
        {
            var nums = Console.ReadLine().Split();
            for (int j = 0; j < i; j++)
            {
                if (nums[j] != "0")
                    pinList.Add(pinNum);
                pinNum--;
            }
        }
        pinList.Sort();
        Console.WriteLine($"{pinList[0]}\n{pinList.Count}");
    }
}