using System;

namespace ProgStudy1.Paiza04_22;
public class Class2_2
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var ans = 1;

        for (var i = 2; i <= num; i++)
        {
            var count = 0;
            while (num % i == 0)
            {
                num /= i;
                count++;
            }
            ans *= count + 1;
        }

        Console.WriteLine(ans);
    }
}