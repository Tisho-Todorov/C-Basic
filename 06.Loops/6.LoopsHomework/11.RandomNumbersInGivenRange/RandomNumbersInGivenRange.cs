using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Random rnd = new Random();

        if (min <= max)
        {


            for (int i = 0; i <= n; i++)
            {
                int generator = rnd.Next(min, max);
                Console.WriteLine(generator);
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}