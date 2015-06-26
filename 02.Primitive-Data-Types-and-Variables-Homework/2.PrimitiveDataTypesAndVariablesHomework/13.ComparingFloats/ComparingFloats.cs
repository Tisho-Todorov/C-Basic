using System;

class ComparingFloats
{
    static void Main()
    {
        bool result = false;
        Console.WriteLine("Enter the first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double secondNumber = double.Parse(Console.ReadLine());

        double deduction = firstNumber - secondNumber;
        deduction = Math.Abs(deduction);
        Console.WriteLine(deduction);
        if (deduction < 0.000001)
        {
            result = true;
        }
        Console.WriteLine("({0};{1})\u2192{2}", firstNumber, secondNumber, result);
        Console.Title = "Created by T.Todorov";
    }
}