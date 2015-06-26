using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine(0); 
        }  
        else
        {
            int first = 0;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            int third = 0;
            for (int i = 2; i < n; i++)
            {
                third = first + second;
                Console.WriteLine(third + " ");
                first = second;
                second = third;
            }
        }
        Console.WriteLine("See you around");
    }
}