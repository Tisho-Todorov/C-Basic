﻿using System;

class PrintCurrentDate
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.Title = "Created by T.Todorov";
    }
}
