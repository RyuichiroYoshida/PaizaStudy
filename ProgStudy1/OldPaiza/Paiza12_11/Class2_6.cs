using System;

namespace ProgStudy1.OldPaiza.Paiza12_11;
public class Class2_6
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var arrA = Console.ReadLine().Split();
        var arrB = Console.ReadLine().Split();
        for (int i = 0, count = 0; i < nums[0]; i++)
        {
            if (arrA[i] == arrB[count])
            {
                count++;
            }
            if (count == arrB.Length)
            {
                Console.WriteLine("Yes");
                return;
            }
        }
        Console.WriteLine("No");
    }
}