using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("When you have a birthday: ");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        int age = (int)((DateTime.Now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine("You are " + age + " years old");
        Console.WriteLine("After ten years you will be at the age of " + (age + 10));
        Console.Title = "Created by T.Todorov";
    }
}
