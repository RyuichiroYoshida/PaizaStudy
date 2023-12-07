using System;
using System.Linq;

namespace ProgStudy1.Paiza12_11;
public class Class1_4
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var list = Console.ReadLine().Split().ToList();
        for (int i = 0; i < nums[1]; i++)
        {
            var order = Console.ReadLine().Split();
            if (order[0] == "0")
            {
                list.Add(order[1]);
            }
            else if (order[0] == "1")
            {
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                var str = "";
                foreach (var item in list)
                {
                    str += item + " ";
                }
                Console.WriteLine(str.Trim());
            }
        }
    }
}