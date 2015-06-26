using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("This program calculate perimeter and area of the circle!");
        Console.WriteLine("Please give us the radius of the circle");
        
        Console.Write("r = ");
        double r = double.Parse(Console.ReadLine());

        double circlePerimeter = (2 * Math.PI * r);
        double circleArea = (Math.PI * r * r);
        Console.WriteLine("The perimeter and area of your figure is:" + "\n" + "Perimeter: {0:#.##}" + "\n" + "Area: {1:#.##}",circlePerimeter ,circleArea);
        Console.WriteLine("Thank you - see you around!");
        Console.Title = "Created by T.Todorov";
    }
}