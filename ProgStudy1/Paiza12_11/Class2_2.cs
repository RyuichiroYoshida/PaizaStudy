using System;

namespace ProgStudy1.Paiza12_11;
public class Class2_2
{
    static void Main()
    {
        var maxSum = int.MinValue;
        var ansNum = 0;
        var num = int.Parse(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (num == 3)
        {
            Console.WriteLine(1);
            return;
        }
        for (int i = 0; i < num - 2; i++)
        {
            var sum = 0;
            for (int j = i; j < i + 3; j++)
            {
                sum += nums[j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                ansNum = i;
            }
        }
        Console.WriteLine(ansNum + 1);
    }
}