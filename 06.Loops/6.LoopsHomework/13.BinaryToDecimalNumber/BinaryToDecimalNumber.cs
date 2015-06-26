using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        long result = 0L;
        
        foreach (char ch in number)
        {
            
            result = Convert.ToInt64(number, 2);
        }
        Console.WriteLine(result);
    }
}