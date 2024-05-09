using System;

namespace ProgStudy1.OldPaiza.Paiza10_30;
class Class7
{
    static void Main()
    {
        for (var i = 1; i <= 9; i++)
        {
            for (var j = 1; j <= 9; j++)
            {
                if (j != 9)
                {
                    Console.Write(i * j + " ");
                    continue;
                }
                Console.Write(i * j + "\n");
            }
        }
    }
}