using System;

namespace Paiaza11_13;
class Class5
{
    static void Main()
    {
        for (var i = 0; i < 24; i++)
        {
            for (var j = 0; j < 60; j++)
            {
                if ((i + j) % 3 == 0)
                    Console.Write("FIZZ");
                else if ((i + j) % 5 == 0)
                    Console.Write("BUZZ");
                else
                    Console.WriteLine();
            }
        }
    }
}