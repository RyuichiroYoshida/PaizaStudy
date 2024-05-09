using System;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class2_3
{
    static void Main()
    {
        var notNullIndex = 404;
        var n = int.Parse(Console.ReadLine());
        var ary = new string?[n];
        for (int i = 0; i < n; i++)
        {
            notNullIndex = ArrayCheck(ary, 0);
            var action = Console.ReadLine();
            if (action == "out")
            {
                if (notNullIndex != 404)
                    ary[notNullIndex] = null;
            }
            else if (action.Contains("in"))
            {

            }
        }
    }
    private static void AddQueue(string[] ary, string addLine)
    {
        var newAry = new string[ary.Length];
        var notNullIndex = 0;
        for (int i = 0; i < ary.Length; i++)
        {
            if (ary != null)
            {
                notNullIndex++;
            }
        }
    }
    private static int ArrayCheck(string[] ary, int startNum)
    {
        for (int i = startNum; ary.Length > 0; i++)
        {
            if (ary[i] != null)
                return i;
        }
        return 404;
    }
}