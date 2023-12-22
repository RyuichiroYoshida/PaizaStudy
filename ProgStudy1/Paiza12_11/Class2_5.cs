using System;
using System.Linq;

namespace ProgStudy1.Paiza12_11;
public class Class2_5
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var arrA = Console.ReadLine().Split();
        var arrB = Console.ReadLine().Split();
        for (int i = 0; i < nums[0] - (nums[1] - 1); i++)
        {
            if (arrA.Skip(i).Take(nums[1]).SequenceEqual(arrB))
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}