using System;

class Class3
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var ans = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (ans > num)
                ans = num;
        }
        Console.WriteLine(ans);
    }
}