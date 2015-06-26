using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please give us width and height of your Rectangle:");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double areaOfRectangle = (width * height);
        Console.WriteLine("The area of your Rectangle is: {0}" ,areaOfRectangle);
        double perimeterOfrectangle = 2*(width + height);
        Console.WriteLine("The perimeter of your Rectangle is: {0}",perimeterOfrectangle);
        Console.Title = "Created by T.Todorov";
    }
}