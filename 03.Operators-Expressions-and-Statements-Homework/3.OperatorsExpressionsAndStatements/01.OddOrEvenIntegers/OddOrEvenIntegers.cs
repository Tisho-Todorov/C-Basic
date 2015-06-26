using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Give us a number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine("Your number is even");
        else
            Console.WriteLine("Your number is odd");
        Console.Title = "Created by T.Todorov";
    }
}