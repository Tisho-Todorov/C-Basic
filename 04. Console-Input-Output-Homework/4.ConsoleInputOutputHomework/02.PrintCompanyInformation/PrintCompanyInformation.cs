using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Good evening may I ask you for your company ?");

        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("After all this may I ask you for your manager ?");

        Console.Write("What is the first name of your manager: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("What is the last name of the manager: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Could you tell me his or her phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("{0}" + "\n" + "Company address: {1}",companyName ,companyAddress);
        Console.WriteLine(" Phone number: {0}" + "\n" + " Fax number: {1}" + "\n" + " Web site: {2}",companyPhoneNumber ,faxNumber ,webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName ,managerLastName ,managerAge ,managerPhoneNumber);
        Console.Title = "Created by T.Todorov";
    }
}