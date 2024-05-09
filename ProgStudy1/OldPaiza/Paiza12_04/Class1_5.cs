using System;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class1_5
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        int[][] nums = new int[num][];
        var count = 0;
        for (int i = 0; i < num - 1; i++)
        {
            nums[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
        var check = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var k = int.Parse(Console.ReadLine());
        for (int i = 0; i < nums.Length; i++)
        {
            if (Math.Abs(check[0] - nums[i][0]) + Math.Abs(check[1] - nums[i][1]) <= k)
                count++;
        }
        Console.WriteLine(count);
    }
}

