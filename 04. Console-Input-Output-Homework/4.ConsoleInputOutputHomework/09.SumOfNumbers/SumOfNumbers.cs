using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculate sum of N numbers");
        Console.Write("Please input first how many numbers you want to calculate: ");
        
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Now enter your numbers");
        double sum = 0;
        double number = double.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of your numbers is: {0}", sum);
        Console.WriteLine("Thank you and see you next time");
        Console.Title = "Created by T.Todorov";
    }
}