using System;

class Class14
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var ans = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(ans);
        Console.WriteLine($"{ans[n - 1]} {ans[0]}");
    }
}