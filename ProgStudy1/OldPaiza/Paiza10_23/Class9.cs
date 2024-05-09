using System;
class Class9
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var ans = Console.ReadLine().Split();
        var k = Console.ReadLine();
        for (var i = 0; i < n; i++)
        {
            if (ans[i] == k)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
        Console.WriteLine(0);
    }
}