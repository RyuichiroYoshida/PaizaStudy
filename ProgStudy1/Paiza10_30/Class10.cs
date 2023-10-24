using System;
using System.Collections.Generic;

namespace Paiaza10_30;
class Class10
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var hashList = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            hashList.Add(int.Parse(Console.ReadLine()));
        }
        foreach (var item in hashList)
        {
            Console.WriteLine(item);
        }
    }
}