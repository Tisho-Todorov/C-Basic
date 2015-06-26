using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Tisho";
        string middleName = "Todorov";
        string lastName = "Todorov";
        decimal moneyBalance = 50000m;
        string bankName = "BNB";
        string IBAN = "BG99STSA66996699669966";
        string BIC_Code = "STSBNBSA";
        long creditCardNumber1 = 6699669966996699;
        long creditCardNumber2 = 3399339933993399;
        long creditCardNumber3 = 6633663366336633;
        Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", firstName, middleName, lastName, moneyBalance, bankName, IBAN, BIC_Code, creditCardNumber1, creditCardNumber2, creditCardNumber3);
        Console.Title = "Created by T.Todorov";
    }
}