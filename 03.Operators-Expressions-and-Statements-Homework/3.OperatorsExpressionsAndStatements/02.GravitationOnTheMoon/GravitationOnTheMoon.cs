using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Tell me your weight after lunch:");
        double weight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = (weight * 0.17);
        Console.WriteLine("Your weight on the Moon will be: {0}" ,weightOnTheMoon);
        Console.Title = "Created by T.Todorov";
    }
}