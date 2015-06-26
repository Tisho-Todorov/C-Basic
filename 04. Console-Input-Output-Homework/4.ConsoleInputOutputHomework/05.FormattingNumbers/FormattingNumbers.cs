using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please give us some numbers");
        
        Console.Write("Integer number a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Floating-point number b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Floating-point number c = ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|", a);    //pad left -10, X convert to hexadecimal
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0') + "|"); //binary form
        
        Console.Write("{0,10:0.00}|", b);   //pad right 10

        Console.Write("{0,-10:0.000}|", c);
        Console.WriteLine("See you next time");
        Console.Title = "Created by T.Todorov";

    }
}