using System;

class Class5
{
    static void Main()
    {
        var n = Console.ReadLine().Split();
        for (int i = 1; i <= int.Parse(n[0]); i++)
        {
            if (int.Parse(n[1]) == int.Parse(Console.ReadLine()))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}