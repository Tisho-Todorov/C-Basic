using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five random numbers");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest number is a = {0}", a);
        }
        else
        {
            if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The biggest number is b = {0}", b);
            }
            else
            {
                if (a < c && b < c && d < c && e < c)
                {
                    Console.WriteLine("The biggest number is c = {0}", c);
                }
                else
                {
                    if (a < d && b < d && c < d && e < d)
                    {
                        Console.WriteLine("The biggest number is d = {0}", d);
                    }
                    else
                    {
                        if (a < e && b < e && c < e && d < e)
                        {
                            Console.WriteLine("The biggest number is e = {0}", e);
                        }
                    }
                }
            }
        }
        Console.WriteLine("Good night!");
        Console.Title = "Created by T.Todorov";
    }
}