using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This program calculate roots of a Quadratic Equation");
        Console.WriteLine("Please give us a, b and c of the Quadratic Equation");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (b == 0)
        {
            double x1 = Math.Sqrt(-c / a);
            double x2 = -Math.Sqrt(-c / a);
            Console.WriteLine("The first root is: {0}", x1);
            Console.WriteLine("The second root is: {0}", x2);
        }
        else
        {
            double D = (b * b) - 4 * a * c;
            Console.WriteLine("Your discriminant is: {0}", D);

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("The first root is: {0}", x1);
                Console.WriteLine("The second root is: {0}", x2);
            }
            else
            {
                if (D == 0)
                {
                    double x0 = -b / (2 * a);
                    Console.WriteLine("When discriminant = 0, x1 = x2 in this case you have one root: {0}", x0);
                }
                else
                {
                    Console.WriteLine("In this case there is no solution in real numbers!!!");
                }
            }

        }
        Console.Title = "Created by T.Todorov";
    }
}