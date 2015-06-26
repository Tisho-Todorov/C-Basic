﻿using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultsCount = 0;
        for (int num1 = 111; num1 <= 777; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;

            if (AllowedValues(num1) && AllowedValues(num2) && AllowedValues(num3) &&
                 num3 <= 777 && (SumOfDigits(num1) + SumOfDigits(num2)
                + SumOfDigits(num3)) == sum)
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                resultsCount++;
            }

        }
        if (resultsCount == 0)
            Console.WriteLine("No");


    }
    private static bool AllowedValues(int num)
    {
        string digits = num.ToString();
        while (num > 0)
        {
            foreach (var element in digits)
            {
                if (element < 1 || element > 7)
                {
                    return false;
                }
            }

        } return true;
    }
    private static int SumOfDigits(int num)
    {
        int sum = 0;

        while (num > 0)
        {

            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
}