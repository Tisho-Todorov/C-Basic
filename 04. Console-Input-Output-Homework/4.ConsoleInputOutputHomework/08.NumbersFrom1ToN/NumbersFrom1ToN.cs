using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Please give us one integer number");

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i); 
        }
        Console.WriteLine("See you next time");
        Console.Title = "Created by T.Todorov";
    }
}