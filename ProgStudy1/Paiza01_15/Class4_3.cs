using System;

namespace ProgStudy1.Paiza01_15;
public class Class4_3
{
    static void Main()
    {
        var temp = int.Parse(Console.ReadLine());
        if (temp < 0)
        {
            Console.WriteLine("ice day");
        }
        else if (temp >= 35)
        {
            Console.WriteLine("extremely hot day");
        }
        else if (temp >= 30)
        {
            Console.WriteLine("hot summer day");
        }
        else if (temp >= 25)
        {
            Console.WriteLine("summer day");
        }
        else
        {
            Console.WriteLine("normal day");
        }
    }
}