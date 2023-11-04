using System;

namespace Paiaza11_06;
class Class3
{
    static void Main()
    {
        var count = 0;
        var num = int.Parse(Console.ReadLine());
        while (num % 2 == 0)
        {
            num /= 2;
            count++;
        }
        Console.WriteLine(count);
    }
}