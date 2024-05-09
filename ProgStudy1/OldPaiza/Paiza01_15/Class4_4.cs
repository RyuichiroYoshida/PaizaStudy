using System;
using System.Linq;

namespace ProgStudy1.OldPaiza.Paiza01_15;
public class Class4_4
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var temps = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(Math.Abs(temps.Max() + Math.Abs(temps.Min())));
    }
}