using System;
class Class7
{
    static void Main()
    {
        var n = Console.ReadLine().Split();
        for (int i = 0; i < int.Parse(n[0]); i++)
        {
            Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(n[1]));
        }
    }
}