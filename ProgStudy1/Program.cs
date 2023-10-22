using System;

class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        if (n % 15 == 0)
            Console.WriteLine("FizzBuzz");
        else if (n % 5 == 0)
            Console.WriteLine("Buzz");
        else if (n % 3 == 0)
            Console.WriteLine("Fizz");
        else
            Console.WriteLine(n);
    }
}