using System;

namespace ProgStudy1.OldPaiza.Paiza11_13;
class Class6
{
    static void Main()
    {
        var max = 0;
        for (var i = 98; 1 <= i; i--)
        {
            for (var j = 1; j <= 98; j++)
            {
                if (i * i * i + j * j * j < 100000)
                    if (max < i * j)
                        max = i * j;
            }
        }
        Console.WriteLine(max);
    }
}