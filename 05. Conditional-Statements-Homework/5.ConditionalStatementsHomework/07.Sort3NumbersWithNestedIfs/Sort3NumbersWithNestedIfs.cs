using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Hello and Welcome, please enter three random numbers");
        
        Console.Write("First number = ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number = ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Third number = ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
        }
        else if (secondNumber > firstNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
        }
        else if(secondNumber > thirdNumber && thirdNumber > firstNumber)
	    {
            Console.WriteLine("Result = {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
	    }
        else if(firstNumber > thirdNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
        }
        else if(thirdNumber > secondNumber && secondNumber > firstNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
        }
        else if(thirdNumber > firstNumber && firstNumber > secondNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
        }
        else if(firstNumber == secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
        }
        else if(firstNumber == thirdNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
        }
        else if(secondNumber == thirdNumber && thirdNumber > firstNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
        }
        else if (firstNumber == secondNumber && firstNumber < thirdNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
        }
        else if (firstNumber == thirdNumber && thirdNumber < secondNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
        }
        else if (secondNumber == thirdNumber && thirdNumber < firstNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
        }
        else if(firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("Result = {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            Console.WriteLine("Result = invalid input, try again");
        }
        Console.WriteLine("See you around");
        Console.Title = "Created by T.Todorov";
    }
}