using System;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class2_4
{
    static void Main()
    {
        var min = int.MaxValue;
        var n = int.Parse(Console.ReadLine());
        var data = new int[n];
        var ans = new int[2];
        for (int i = 0; i < n; i++)
        {
            data[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (i == j)
                    continue;
                if (Math.Abs(data[i] - data[j]) < min)
                {
                    min = Math.Abs(data[i] - data[j]);
                    ans[0] = data[i];
                    ans[1] = data[j];
                }
            }
        }
        Array.Sort(ans);
        Console.WriteLine($"{ans[0]}\n{ans[1]}");
    }
}