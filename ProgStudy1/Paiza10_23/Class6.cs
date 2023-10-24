using System;

class Class6
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];
        var counter = 0;
        var ans = 0;
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(nums);
        foreach (var item in nums)
        {
            if (ans != item)
            {
                ans = item;
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}