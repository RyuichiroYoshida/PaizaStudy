using System;
class Class10
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var arr = Console.ReadLine().Split();
        var k = Console.ReadLine();
        var ans = 0;
        for (var i = 0; i < n; i++)
        {
            if (arr[i] == k)
            {
                ans = i;
            }
        }
        Console.WriteLine(ans == 0 ? 0 : ans + 1);
    }
}