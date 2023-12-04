using System;

namespace ProgStudy1.Paiza12_04;
public class Class1_1
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < num; i++)
        {
            if (nums[i] % 2 == 0)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
    }
}

