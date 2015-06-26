using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please enter score in the range 1…9");

        Console.Write("Score = ");
        int score = int.Parse(Console.ReadLine());

        if (1 <= score && score <= 3)
        {
            int bonysScore = score * 10;
            Console.WriteLine(bonysScore);
        }
        else
        {
            if (4 <= score && score <= 6)
            {
                int bonusScore = score * 100;
                Console.WriteLine(bonusScore);
            }
            else
            {
                if (7 <= score && score <= 9)
                {
                    int bonusScore = score * 1000;
                    Console.WriteLine(bonusScore);
                }
                else
                {
                    Console.WriteLine("You put invalid score");
                }
            }
        }
        Console.WriteLine("Enjoy yourself");
        Console.Title = "Created by T.Todorov";
    }
}