using System;

class Class4
{
    static void Main()
    {
        var n = Console.ReadLine().Split();
        for (int i = 0; i < int.Parse(n[0]); i++)
        {
            if (int.Parse(n[1]) == int.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Yes");
                return;
            }
        }
        Console.WriteLine("No");
    }
}