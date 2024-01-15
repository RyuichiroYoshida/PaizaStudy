using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgStudy1.Paiza01_15;
public class Class4_7
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var playerData = new int[n][];
        var data1List = new List<int>();
        var data2List = new List<int>();
        var data3List = new List<int>();

        for (int i = 0; i <= n; i++)
        {
            playerData[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            data1List[i] = playerData[i][1];
            data2List[i] = playerData[i][2];
            data3List[i] = playerData[i][3];
        }
        var data1Max = data1List.Max();
        var data2Max = data2List.Max();
        var data3Max = data3List.Max();
        for (int i = 0; i <= n; i++)
        {
            var count = 0;
            foreach (var item in playerData[i])
            {
            }
        }
    }
}