using System;
using System.Linq;

namespace ProgStudy1.OldPaiza.Paiza12_04;
public class Class2_5
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int N = line[0];
        int M = line[1];
        int L = line[2];

        int[][] commands = new int[N][];
        int[][] parameterGroup = new int[L][];

        for (int i = 0; i < N; i++)
        {
            commands[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
        for (int i = 0; i < L; i++)
        {
            parameterGroup[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (i == 0) continue;
            else
            {
                var ans = parameterGroup[i].Select((x, index) => x - parameterGroup[i - 1][index]).ToArray();
                for (int j = 0; j < N; j++)
                {
                    if (commands[j].SequenceEqual(ans))
                    {
                        Console.WriteLine(j + 1);
                    }
                }
            }
        }

    }
}