using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Clear();
        Random rnd = new Random();

        if (1 <= n)
        {


            for (int i = 1; i <= n; i++)
            {
                int generator = rnd.Next(1, n + 1);
                Console.WriteLine(generator);
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}