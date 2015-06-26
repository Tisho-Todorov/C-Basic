using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Please choose a playing card");
        string character = Console.ReadLine();
        int card;
        if (character == "J" || character == "Q" || character == "K" || character == "A")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            card = int.Parse(character);
            if (2 <= card && card <= 10)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        Console.WriteLine("Good game thank you !");
        Console.Title = "Created by T.Todorov";
    }
}