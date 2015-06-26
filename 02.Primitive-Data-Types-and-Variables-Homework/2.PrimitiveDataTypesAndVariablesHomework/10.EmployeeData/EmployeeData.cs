using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Tisho";
        string familyName = "Todorov";
        byte age = 25;
        char gender = 'M';
        string IDnumber = "9966996699";
        uint uniqueEmployeeNumber = 66993366;
        Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}", firstName, familyName, age, gender, IDnumber, uniqueEmployeeNumber);
        Console.Title = "Created by T.Todorov";
    }
}