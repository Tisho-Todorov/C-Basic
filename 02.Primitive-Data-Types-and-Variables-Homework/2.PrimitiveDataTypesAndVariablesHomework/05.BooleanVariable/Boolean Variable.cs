using System;

class BooleanVariable
{
    static void Main()
    {
        Console.WriteLine("What is your gender choose \"m\" or \"f\"?");
        string choice = (Console.ReadLine());
        string choice1 = "f";
        string choice2 = "m";
        if (choice2 != choice)
            Console.WriteLine("Your gender is Female");
        else
            Console.WriteLine("Your gender is Male");
        //or this way
        bool isFemale;
        isFemale = false;
        Console.WriteLine(isFemale);

       
    }
}