using System;

namespace Paiaza10_30;
class Class2_5
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var point = 0;
        for (int i = 0; i < n; i++)
        {
            var ans = Console.ReadLine();
            if ("no_answer" == ans)
                continue;
            if ("correct" == ans)
                point += 2;
            else
                point -= 1;
        }
        Console.WriteLine(point);
    }
}