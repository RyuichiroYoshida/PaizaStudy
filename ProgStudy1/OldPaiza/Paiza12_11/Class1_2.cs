using System;

namespace ProgStudy1.OldPaiza.Paiza12_11;
public class Class1_2
{
    static void Main()
    {
        Console.ReadLine();
        var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var num = int.Parse(Console.ReadLine());
        var ans = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(arr[ans[i] - 1]);
        }
    }
}