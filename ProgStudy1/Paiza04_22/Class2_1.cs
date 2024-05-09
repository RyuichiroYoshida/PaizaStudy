using System;

namespace ProgStudy1.Paiza04_22;
public class Class2_1
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());

        for (var i = 2; i <= num; i++)
        {
            while (num % i == 0)
            {
                num /= i;
                Console.WriteLine(i);
            }
        }
    }
}