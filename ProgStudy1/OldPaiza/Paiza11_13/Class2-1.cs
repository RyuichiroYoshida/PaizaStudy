using System;

namespace ProgStudy1.OldPaiza.Paiza11_13;
class Class2_1
{
    static void Main()
    {
        var line = Console.ReadLine();
        switch (line)
        {
            case "baseball":
                Console.WriteLine(9);
                break;
            case "soccer":
                Console.WriteLine(11);
                break;
            case "rugby":
                Console.WriteLine(15);
                break;
            case "basketball":
                Console.WriteLine(5);
                break;
            case "volleyball":
                Console.WriteLine(6);
                break;
        }
    }
}