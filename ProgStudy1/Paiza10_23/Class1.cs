using System;
class Class1
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var num = 0;
        for (int i = 0; i < n; i++)
        {
            num += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(num);
    }
}