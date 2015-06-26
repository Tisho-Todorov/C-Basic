using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter one positive integer number");

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Output: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("Enjoy yourself");
        Console.Title = "Created by T.Todorov";
    }
}