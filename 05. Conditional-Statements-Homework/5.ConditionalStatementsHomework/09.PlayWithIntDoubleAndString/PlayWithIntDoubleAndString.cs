using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        Console.Write("Your choice = ");
        int choice = int.Parse(Console.ReadLine());

        int integer;
        double number;

        switch (choice)
        {
            case 1: Console.Write("Please enter integer = ");
                break;
            case 2: Console.Write("Please enter a double = ");
                break;
            case 3: Console.Write("Please enter a string: ");
                break;
            default: Console.WriteLine("Invalid input");
                break;
        }

        
        string choose = Console.ReadLine();

        if (Int32.TryParse(choose, out integer))
        {
            integer++;
            Console.WriteLine(integer);
        }

        else if(double.TryParse(choose, out number))
        {
            number++;
            Console.WriteLine(number);  
        }
        else
        {
            choose = choose + "*";
            Console.WriteLine(choose);
        }
        Console.WriteLine("Thank you!");
        Console.Title = "Created by T.Todorov";
    }
}