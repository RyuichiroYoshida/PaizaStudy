using System;

namespace ProgStudy1.OldPaiza.Paiza11_20;
class Class2_7
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var arr = new int[nums[0]];
        for (int i = 0; i < nums[0]; i++)
            arr[i] = i + 1;
        for (int i = 0; i < nums[1]; i++)
        {
            var operate = Console.ReadLine();
            if (operate.Contains("swap"))
            {

                var operates = operate.Split();
                var swapNumA = int.Parse(operates[1]) - 1;
                var swapNumB = int.Parse(operates[2]) - 1;
                var swapA = arr[swapNumA];
                arr[swapNumA] = arr[swapNumB];
                arr[swapNumB] = swapA;
            }
            else if (operate.Contains("reverse"))
                Array.Reverse(arr);
            else
            {
                var operates = operate.Split();
                var resize = int.Parse(operates[1]);
                if (resize < arr.Length)
                    Array.Resize(ref arr, resize);
            }
        }
        foreach (var item in arr)
            Console.WriteLine(item);
    }
}