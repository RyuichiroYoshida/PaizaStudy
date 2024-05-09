using System;

namespace ProgStudy1.OldPaiza.Paiza11_06;
class Class1
{
    static void Main()
    {
        var sum = 0;
        var n = Console.ReadLine().ToCharArray();
        for (var i = 0; i < n.Length; i++)
        {
            sum += int.Parse(n[i].ToString());
        }
        Console.WriteLine(sum);
    }
}