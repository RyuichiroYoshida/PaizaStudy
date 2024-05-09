using System;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class2_2
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < num - 1; i++)
            Console.Write($"{b[i] - a[i]} ");
        Console.WriteLine($"{b[num - 1] - a[num - 1]}");
    }
}