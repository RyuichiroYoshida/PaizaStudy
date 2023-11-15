using System;

namespace Paiaza11_20;
class Class5
{
    static void Main()
    {
        var counter = 0;
        var ans = "";
        var num = int.Parse(Console.ReadLine());
        var nums = new int[num];
        for (int i = 0; i < num; i++)
            nums[i] = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                if (nums[i] + nums[j] == 777)
                {
                    if (counter > 1)
                    {
                        Console.WriteLine("multiple answers");
                        return;
                    }
                    if (nums[i] < nums[j])
                        ans = $"{nums[i].ToString()} {nums[j].ToString()}";
                    else
                        ans = $"{nums[j].ToString()} {nums[i].ToString()}";
                    counter++;
                }
            }
        }
        Console.WriteLine(ans ?? "no answer");
    }

    //private static int CheckNum(int[] nums)
    //{
    //    for (int i = 0;)
    //    return;
    //}
}