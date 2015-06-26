using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please give us two numbers");
        
        Console.Write("First number = ");
        double firstNumber = double.Parse(Console.ReadLine());
        
        Console.Write("Second number = ");
        double secondNumber = double.Parse(Console.ReadLine());

        double greater = (firstNumber > secondNumber ? firstNumber : secondNumber);
        Console.WriteLine("The greater number is: {0}",greater);
        Console.Title = "Created by T.Todorov";
    }
}