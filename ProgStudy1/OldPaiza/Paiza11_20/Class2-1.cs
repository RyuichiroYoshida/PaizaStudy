using System;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class2_1
{
    static void Main()
    {
        var maxScore = int.MinValue;
        var n = int.Parse(Console.ReadLine());
        var rates = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < n; i++)
        {
            var sumScore = 0;
            var score = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < score.Length; j++)
            {
                sumScore += score[j] * rates[j];
            }
            if (sumScore > maxScore)
                maxScore = sumScore;
        }
        Console.WriteLine(maxScore);
    }
}