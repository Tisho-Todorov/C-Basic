using System;
using System.Numerics;
class CalculateNAndKFactorial
{
    static void Main()
    {

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (1 < k && k < n && n < 100)
        {
            BigInteger resuult = 1;
            for (int i = k + 1; i <= n; i++)
            {
                resuult *= (BigInteger)i;
            }
            Console.WriteLine("N!/K! = {0}", resuult);
        }
        else
        {
            Console.WriteLine("out of range");
        }
        Console.Title = "Created by T.Todorov";
    }
}