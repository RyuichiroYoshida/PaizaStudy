using System;

namespace ProgStudy1.OldPaiza.Paiza12_11;
public class Class2_1
{
    static void Main()
    {
        var count = 0;
        var num = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split();
        for (int i = 0; i < num - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}