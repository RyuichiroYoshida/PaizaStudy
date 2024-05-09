using System;

namespace ProgStudy1.Paiza04_22;
public class Class1_1
{
    static void Main()
    {
        // 57は3と19で割り切れます
        int num = 57;

        if (num < 2)
        {
            Console.WriteLine("NO");
            return;
        }

        for (int i = 1; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                Console.WriteLine("NO");
                return;
            }
        }
        Console.WriteLine("YES");
    }
}