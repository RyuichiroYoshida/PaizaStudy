using System;

namespace Paiaza11_13;
class Class7
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var coinA = nums[0];
        var coinB = nums[1];
        var payment = nums[2];
        var ans = payment;

        for (int i = 0; i <= payment / coinA; i++)
        {
            for (int j = 0; i <= payment / coinB; i++)
            {
                if (coinA * i + coinB * j <= payment)
                {
                    payment -= coinA * i + coinB * j;
                }
                else
                    break;
            }
        }
        //Console.WriteLine(Math);
    }
}