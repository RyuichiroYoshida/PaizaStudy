using System;

namespace Paiaza11_13;
class Class2_2
{
    static void Main()
    {
        var hour = int.Parse(Console.ReadLine());
        if (hour <= 6)
            Console.WriteLine("no break");
        else if (hour <= 8)
            Console.WriteLine("45 min");
        else
            Console.WriteLine("60 min");
    }
}