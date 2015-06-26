using System;

class CalculateSumOfNAndM
{
    static void Main()
    {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            float sum = 1;
            float factorial = 1;
            int power = x;
            for (int count = 1; count <= n; count++)
            {
                factorial *= count;
                sum += factorial / x;
                x *= power;
            }
            Console.WriteLine("{0 :F5}", sum);
        
    }
}