using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Please choose digit form 0 to 9");
        
        Console.WriteLine("Your choice = ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 0)
        {
            Console.WriteLine("not a digit");
        }
        else
        {
            switch (choice)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break;
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                default: Console.WriteLine("not a digit");
                    break;
            }
        }
        Console.WriteLine("Good bye");
        Console.Title = "Created by T.Todorov";
    }
}