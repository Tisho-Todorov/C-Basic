using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Divide by 7 and 5");
        Console.WriteLine("Tell me your number");
        int num = int.Parse(Console.ReadLine());
        if (num % 7 == 0 ? true : false)
            Console.WriteLine("Your number could divide by 7");
        else
            Console.WriteLine("Your number could not divide by 7");

        if (num % 5 == 0 ? true : false)
            Console.WriteLine("Your number could divide by 5");
        else
            Console.WriteLine("Your number could not divide by 5");
        Console.Title = "Created by T.Todorov";
        Console.WriteLine("Thank you for your time");
    }
}