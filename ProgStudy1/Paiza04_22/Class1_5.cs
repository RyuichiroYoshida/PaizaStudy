using System;

namespace ProgStudy1.Paiza04_22;
public class Class1_5
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var random = new Random();

        if (num < 2)
        {
            Console.WriteLine("NO");
            return;
        }
        else if (num < 3)
        {
            Console.WriteLine("YES");
            return;
        }

        var fermat = 1;
        var randomNum = 2;
        for (var i = 0; i < num - 1; i++)
        {
            fermat *= randomNum;
            if(fermat % num == 1)
            {
                Console.WriteLine("YES");
                return;
            }
        }
        Console.WriteLine("NO");
    }
}