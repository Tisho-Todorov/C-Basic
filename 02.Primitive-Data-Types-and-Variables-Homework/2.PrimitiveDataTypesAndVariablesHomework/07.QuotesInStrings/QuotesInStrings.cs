using System;

class QuotesInStrings
{
    static void Main()
    {
        string quotes = "\"The use of quotations causes difficulties";
        string withoutquotes = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(quotes + "\"" + "\n" + withoutquotes);
        Console.Title = "Created by T.Todorov";
    }
}