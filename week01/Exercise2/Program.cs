using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int gradePercentage = int.Parse(percentage);
        bool passed;
        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
            passed = true;
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            passed = true;
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
            passed = true;
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }
        
        int remainder = gradePercentage % 10;
        string sign = "";
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        
        if (passed == true)
        {
            if (letter != "A")
            {
                Console.WriteLine($"You are passing this class with a {letter}{sign}, congragulations!");
            }
            else if (sign == "+")
            {
                Console.WriteLine($"You are passing this class with an {letter}, congragulations!");
            }
            else
            {
                Console.WriteLine($"You are passing this class with an {letter}{sign}, congragulations!");
            }
        }
        else
        {
            if (letter != "F")
            {
                Console.WriteLine($"You are currently not passing with a {letter}{sign}. Don't give up though, it's not too late to improve your score");
            }
            else
            {
                Console.WriteLine($"You are currently not passing with an {letter}. Don't give up though, it's not too late to improve your score");
            }
        }
    }
}