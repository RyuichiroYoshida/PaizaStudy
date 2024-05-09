using System;

namespace ProgStudy1.OldPaiza.Paiza01_15;
public class Class4_2
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var salary = data[0];
        if (data[2] >= 20)
        {
            salary += 4 * data[1];
        }
        else if (data[2] >= 15)
        {
            salary += 3 * data[1];
        }
        else if (data[2] >= 10)
        {
            salary += 2 * data[1];
        }
        else
        {
            salary += data[1];
        }
        Console.WriteLine(salary);
    }
}