using System;

class UnicodeCharacter
{
    static void Main()
    {
        Console.WriteLine((char) 42);
        Console.Title = "Created by T.Todorov";

        // or this one

        char symbol = '*';
        Console.WriteLine("The hexadecimal code of symbol '{0}' is: {1}",
            symbol, (int)symbol);
    }
}