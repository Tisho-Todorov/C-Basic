using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three random numbers");
        
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The result is +");
        }
        else
        {
            if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("The result is -");
            }
            else
            {
                if (a > 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("The result is -");
                }
                else
                {
                    if (a < 0 && b > 0 && c > 0)
                    {
                        Console.WriteLine("The result is -");
                    }
                    else
                    {
                        if (a > 0 && b < 0 && c < 0)
                        {
                            Console.WriteLine("The result is +");
                        }
                        else
                        {
                            if (a < 0 && b < 0 && c > 0)
                            {
                                Console.WriteLine("The result is +");
                            }
                            else
                            {
                                if (a < 0 && b > 0 && c < 0)
                                {
                                    Console.WriteLine("The result is +");
                                }
                                else
                                {
                                    if (a < 0 && b < 0 && c < 0)
                                    {
                                        Console.WriteLine("The result is -");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The result is = 0");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}