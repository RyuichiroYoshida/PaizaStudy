using System;
using System.Linq;
class Class8
{
    static void Main()
    {
        var n = Console.ReadLine();
        var ans = Console.ReadLine().Split();
        var k = Console.ReadLine();
        Console.WriteLine(ans.Where(x => x == k).Count());
    }
}