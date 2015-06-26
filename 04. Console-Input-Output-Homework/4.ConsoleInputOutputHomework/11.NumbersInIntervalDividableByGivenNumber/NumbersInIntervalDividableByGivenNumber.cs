using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Plese enter two integer numbers");

        Console.Write("Start = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("End = ");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("P = {0}", count);
        Console.Write("Comments = ");
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ", ");
            }   
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for your time");
        Console.Title = "Created by T.Todorov";
    }
}