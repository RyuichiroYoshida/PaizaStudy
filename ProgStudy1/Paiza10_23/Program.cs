using System;

class Program
{
    public static void Main()
    {
        var n = Console.ReadLine().Split();
        var counter = 0;
        for (int i = 0; i < int.Parse(n[0]); i++)
        {
            if (n[1] == Console.ReadLine())
                counter++;
        }
        Console.WriteLine(counter);
    }
}