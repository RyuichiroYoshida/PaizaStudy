using System;

namespace ProgStudy1.OldPaiza.Paiza01_22;
public class Class1_5
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var getOff = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var getUp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var maxPassengers = 0;
        var passengers = 0;
        for (int i = 0; i < n; i++)
        {
            passengers += getUp[i] - getOff[i];
            if (passengers > maxPassengers)
            {
                maxPassengers = passengers;
            }
        }
        Console.WriteLine(maxPassengers);
    }
}