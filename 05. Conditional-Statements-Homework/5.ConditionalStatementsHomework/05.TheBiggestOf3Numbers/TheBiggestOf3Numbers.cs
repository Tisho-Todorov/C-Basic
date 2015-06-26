using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three random numbers");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is a = {0}", a);
        }
        else
        {
            if (a < b && b > c)
            {
                Console.WriteLine("The biggest number is b = {0}", b);
            }
            else
            {
                if (a < c && b < c)
                {
                    Console.WriteLine("The biggest number is c = {0}", c);
                }
                else
                {
                    Console.WriteLine("You have two equals numbers");
                }
            }
        }
        Console.WriteLine("Goodbye!");
        Console.Title = "Created by T.Todorov";
    }
}