using System;

class Class12
{
    static void Main()
    {
        var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (n[0] > n[1])
            Console.WriteLine($"{n[0]} {n[1]}");
        else
            Console.WriteLine($"{n[1]} {n[0]}");
    }
}