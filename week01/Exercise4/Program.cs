using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int number = -1;
        float sum = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, and type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numberList.Add(number);
            }
        }
        foreach (int line in numberList)
        {
            sum += line;
            if (line > largest)
            {
                largest = line;
            }
        }
        Console.WriteLine($"The sum of your numbers is: {sum}");
        float avg = sum / numberList.Count;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}