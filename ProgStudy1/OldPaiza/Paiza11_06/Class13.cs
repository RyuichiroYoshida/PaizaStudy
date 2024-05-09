using System;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class13
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split();
        for (var i = 1; i <= num; i++)
        {
            if (nums[i - 1] == "1")
                Console.WriteLine(i);
        }
    }
}