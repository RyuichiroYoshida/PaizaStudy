using System;

namespace ProgStudy1.Paiza12_04;
public class Class2_3
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var ans = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            if (nums[i] == ans)
                Console.WriteLine(i + 1);
        }
    }
}