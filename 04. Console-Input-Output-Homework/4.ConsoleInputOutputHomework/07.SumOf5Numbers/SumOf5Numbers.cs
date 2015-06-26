using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please give us five random numbers ");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        string numbers = Convert.ToString(a + " " + b + " " + c + " " + d + " " + e);
        double sum = (a + b + c + d + e);
        Console.WriteLine("Numbers: {0}" + " " +"Sum: {1}", numbers, sum);
        Console.Title = "Created by T.Todorov";
    }
}