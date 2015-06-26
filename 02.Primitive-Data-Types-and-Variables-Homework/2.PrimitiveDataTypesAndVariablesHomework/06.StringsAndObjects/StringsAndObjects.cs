using System;

class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object greeting = (a + " " + b);
        string c = (string)greeting;
        Console.WriteLine(c);
        Console.Title = "Created by T.Todorov";
    }
}