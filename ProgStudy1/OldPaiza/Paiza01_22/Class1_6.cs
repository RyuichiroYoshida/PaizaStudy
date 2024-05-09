using System;

namespace ProgStudy1.OldPaiza.Paiza01_22;
public class Class1_6
{
    static void Main()
    {
        var n = float.Parse(Console.ReadLine());
        var maxOPS = float.MinValue;
        var maxOPSIndex = 0;
        for (int i = 0; i < n; i++)
        {
            var data = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            var sum = data[0] + data[1];
            if (sum > maxOPS)
            {
                maxOPS = sum;
                maxOPSIndex = i;
            }
        }
        Console.WriteLine(maxOPSIndex + 1);
    }
}