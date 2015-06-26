using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? d = null;
        Console.WriteLine("{0} , {1}", a, d);

        a = null + 10;
        d = null + 20.3;

        Console.WriteLine("{0}, {1}", a.GetValueOrDefault(), d.GetValueOrDefault());
        Console.Title = "Created by T.Todorov";
    }
}