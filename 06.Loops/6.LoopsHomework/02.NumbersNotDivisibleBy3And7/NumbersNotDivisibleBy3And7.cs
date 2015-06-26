using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Please enter one positive integer number");

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Output: ");
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                
            }
            else
            {
                Console.Write(i + " ");
            }
            
        }
        Console.WriteLine("See you around");
        Console.Title = "Created by T.Todorov";
    }
}