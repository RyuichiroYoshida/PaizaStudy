using System;
using System.Linq;

class Class13
{
    static void Main()
    {
        var n = Console.ReadLine().Split().ToList().ConvertAll(x => int.Parse(x));
        Console.WriteLine($"{n.Max()} {n.Min()}");
    }
}