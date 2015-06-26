using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Waiting for your number:");
        int number = int.Parse(Console.ReadLine());
        int restNumber = number / 100;
        int thirdDigit = restNumber % 10;
        bool isSeven = thirdDigit == 7;
        if (thirdDigit == 7 ? true : false)
            Console.WriteLine("The third digit of your number is 7");
        else
            Console.WriteLine("The third digit of your number is different by 7");
        Console.WriteLine("See you around");
        Console.Title = "Created by T.Todorov";
    }
}