using System;
using System.Linq;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class2_4
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var arr = new int[nums[1]][];
        for (int i = 0; i < nums[0]; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
        var ans = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < nums[0]; i++)
        {
            var check = ans.SequenceEqual(arr[i]);
            if (check)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
    }
}