using System;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class1_2
{
    static void Main()
    {
        var ans = 0;
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < num; i++)
        {
            if (nums[i] < 3)
                continue;
            if (nums[i] % 2 == 1)
                ans = i + 1;
        }
        Console.WriteLine(ans);
    }
}

