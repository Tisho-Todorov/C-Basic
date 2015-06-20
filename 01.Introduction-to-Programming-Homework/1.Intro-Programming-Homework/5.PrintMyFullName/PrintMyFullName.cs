using System;

class PrintMyFullName
{
    static void Main()
    {
        string FirstName = "Tisho";
        string LastName = "Todorov";
        string FullName = FirstName + " " + LastName;
        Console.WriteLine(FullName);
        Console.Title = "Created by T.Todorov";
    }
}
