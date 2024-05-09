using System;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class4
{
    static void Main()
    {
        var capsLock = false;
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var word = Console.ReadLine();
            if (word == "capslock")
            {
                capsLock = !capsLock;
                continue;
            }
            else if (word.Contains("shift"))
            {
                Console.Write(word.Split()[1].ToUpper());
                continue;
            }
            if (capsLock)
            {
                if (word.Contains("shift"))
                {
                    Console.Write(word.Split()[1]);
                }
                else
                    Console.Write(word.ToUpper());
            }
            else
                Console.Write(word);
        }
    }
}