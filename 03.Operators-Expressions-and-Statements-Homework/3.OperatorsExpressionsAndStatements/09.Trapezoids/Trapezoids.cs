using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("This program calculates trapezoid's area ");
        Console.Write("Please give us side a = ");
        double a = double.Parse(Console.ReadLine());
 
        Console.Write("Please give us side b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please give us the height of trapezoid h = ");
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = ((a + b) * h) /2;

        Console.WriteLine("The area of your trapezoid is = " + trapezoidArea);
        Console.Title = "Created by T.Todorov";
        Console.WriteLine("Thank you for your time see you around!");

    }
}