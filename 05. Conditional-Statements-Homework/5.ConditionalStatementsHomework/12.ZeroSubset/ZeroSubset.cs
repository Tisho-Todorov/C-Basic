using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Please enter five random numbers");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        if (a + b == 0 || a + c == 0 || a + d == 0 || a + e == 0 || b + c == 0 || b + d == 0 || b + e == 0 || c + e == 0 || d + e == 0 || a + b + c + d + e == 0 || a + b + c + d == 0 || a + c + d + e == 0 || a + c + d == 0 || a + d + e == 0 || a + b + d + e == 0 || a + b + d == 0 || b + c + d + e == 0 || b + d + e == 0 || b + c + d == 0)
        {



            if (a + b + c + d + e == 0)
            {
                int isZero = (a + b + c + d + e);
                Console.WriteLine("Result: {0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, isZero);
            }
            else
            {
                if (a + b + c + d == 0)
                {
                    int isZero = (a + b + c + d);
                    Console.WriteLine("Result: {0} + {1} + {2} + {3} = {4}", a, b, c, d, isZero);
                }
                if (a + b + c == 0)
                {
                    int isZero = (a + b + c);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", a, b, c, isZero);
                }
                if (a + b == 0)
                {
                    int isZero = (a + b);
                    Console.WriteLine("Result: {0} + {1} = {3}", a, b, isZero);
                }




                if (a + c + d + e == 0)
                {
                    int isZero = (a + c + d + e);
                    Console.WriteLine("Result: {0} + {1} + {2} + {3} = {4}", a, c, d, e, isZero);
                }
                if (a + c + d == 0)
                {
                    int isZero = (a + c + d);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", a, c, d, isZero);
                }
                if (a + c == 0)
                {
                    int isZero = (a + c);
                    Console.WriteLine("Result: {0} + {1} = {2}", a, c, isZero);
                }




                if (a + d + e == 0)
                {
                    int isZero = (a + d + e);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", a, d, e, isZero);
                }
                if (a + d == 0)
                {
                    int isZero = (a + d);
                    Console.WriteLine("Result: {0} + {1} = {2}", a, d, isZero);
                }
                if (a + e == 0)
                {
                    int isZero = (a + e);
                    Console.WriteLine("Result: {0} + {1} = {2}", a, e, isZero);

                }


                // b case

                if (b + c + d + e == 0)
                {
                    int isZero = (b + c + d + e);
                    Console.WriteLine("Result: {0} + {1} + {2} + {3} = {4}", b, c, d, e, isZero);
                }
                if (b + c + d == 0)
                {
                    int isZero = (b + c + d);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", b, c, d, isZero);
                }
                if (b + c == 0)
                {
                    int isZero = (b + c);
                    Console.WriteLine("Result: {0} + {1} = {2}", b, c, isZero);
                }
                if (b + d == 0)
                {
                    int isZero = (b + d);
                    Console.WriteLine("Result: {0} + {1} = {2}", b, d, isZero);
                }
                if (b + e == 0)
                {
                    int isZero = (b + e);
                    Console.WriteLine("Result: {0} + {1} = {2}", b, e, isZero);
                }


                // c case


                if (c + d + e == 0)
                {
                    int isZero = (c + d + e);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", c, d, e, isZero);
                }
                if (c + d == 0)
                {
                    int isZero = (c + d);
                    Console.WriteLine("Result: {0} + {1} = {2}", c, d, isZero);
                }
                if (c + e == 0)
                {
                    int isZero = (c + e);
                    Console.WriteLine("Result: {0} + {1} = {2}", c, e, isZero);
                }

                // d case

                if (d + e == 0)
                {
                    int isZero = (d + e);
                    Console.WriteLine("Result: {0} + {1} = {2}", d, e, isZero);
                }




                if (a + b + d + e == 0)
                {
                    int isZero = (a + b + d + e);
                    Console.WriteLine("Result: {0} + {1} + {2} + {3} = {4}", a, b, d, e, isZero);
                }
                if (a + b + d == 0)
                {
                    int isZero = (a + b + d);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", a, b, d, isZero);
                }
                if (b + d + e == 0)
                {
                    int isZero = (b + d + e);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", b, d, e, isZero);
                }
                if (b + c + e == 0)
                {
                    int isZero = (b + c + e);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", b, c, e, isZero);
                }
                if (a + c + e == 0)
                {
                    int isZero = (a + c + e);
                    Console.WriteLine("Result: {0} + {1} + {2} = {3}", a, c, e, isZero);
                }
            }
        }
        else
        {
            Console.WriteLine("no zero subset");

        }
        Console.Title = "Created by T.Todorov";
    }
}