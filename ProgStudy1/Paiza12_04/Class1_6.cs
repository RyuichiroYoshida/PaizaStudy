using System;

namespace ProgStudy1.Paiza12_04;
public class Class1_6
{
    static void Main()
    {
        var count = 0;
        var num = int.Parse(Console.ReadLine());
        int[] posX = new int[num];
        int[] posY = new int[num];
        for (int i = 0; i < num; i++)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            posX[i] = nums[0];
            posY[i] = nums[1];
        }
        var numsX = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var numsY = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0;i < num; i++)
        {
            if (posX[i] < numsX[0] || numsX[1] < posX[i])
                continue;
            if (posY[i] < numsY[0] || numsY[1] < posY[i])
                continue;
            count++;
        }
        Console.WriteLine(count);
    }
}

