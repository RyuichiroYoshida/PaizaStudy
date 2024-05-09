using System;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class1
{
    static void Main()
    {
        var str = Console.ReadLine();
        for (int i = str.Length; i > 0; i--)
        {
            Console.Write(str[i - 1]);
        }
    }
}