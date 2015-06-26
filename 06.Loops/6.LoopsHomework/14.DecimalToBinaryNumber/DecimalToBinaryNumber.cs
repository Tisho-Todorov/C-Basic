using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        string bin = null;

        bin = Convert.ToString(number, 2);
        Console.WriteLine(bin);
    }
}