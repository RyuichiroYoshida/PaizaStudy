using System;
using System.Linq;

namespace ProgStudy1.Paiza04_22;
public class Class3_2
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double m1 = nums[0];
        double m2 = nums[1];
        double b1 = nums[2];
        double b2 = nums[3];

        for (double i = 0; i < m1 * m2; i++)
        {
            if (i % m1 == b1 && i % m2 == b2)
            {
                Console.WriteLine(i);
            }
        }
    }
}