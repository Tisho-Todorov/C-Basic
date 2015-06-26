using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter two doubleeger numbers");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("The first number is greater: b = {1} a = {0}", a, b);
        }
        else
        {
            Console.WriteLine("The second number is greater: a = {0} b = {1}", a, b);
        }
    }
}