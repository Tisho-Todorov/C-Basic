using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please give us some numbers:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double sum = (a + b + c);
        Console.WriteLine("The sum of your numbers is: {0}", sum);
        Console.WriteLine("Thank you and enjoy yourself !");
        Console.Title = "Created by T.Todorov";
    }
}