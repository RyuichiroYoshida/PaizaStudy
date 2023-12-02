using System;
using System.Collections.Generic;

namespace Paiaza11_20;
class Class2_5
{
    static void Main()
    {
        var nums = Console.ReadLine().Split();
        var seatCount = int.Parse(nums[1]);
        var removeSeat = int.Parse(nums[2]);
        var seats = new HashSet<string>();
        for (int i = 0; i < seatCount; i++)
        {
            if (i <= removeSeat)
            {
                Console.ReadLine();
                continue;
            }
            seats.Add(Console.ReadLine());
        }
        foreach (var num in seats)
            Console.WriteLine(num);
    }
}