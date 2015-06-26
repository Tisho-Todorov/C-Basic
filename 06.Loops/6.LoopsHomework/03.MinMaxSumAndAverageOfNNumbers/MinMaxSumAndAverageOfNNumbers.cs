using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculate sum of N numbers");
        Console.Write("Please input first how many numbers you want to calculate: ");

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter your numbers");
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;

            if (number < min)
            {
                min = number;
            }
            else if(number > max)
            {
                max = number;
            }

        }
        double avg = (double)sum / n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);

        Console.WriteLine("It's late now but I'll keep working");
        Console.Title = "Created by T.Todorov";
       
    }
}