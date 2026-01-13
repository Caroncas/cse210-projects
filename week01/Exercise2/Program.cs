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
        if (gradePercentage < 96 && gradePercentage > 60)
        {
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder < 3)
            {
                sign = "-";
            }
        }
         if (passed == true)
        {
                Console.WriteLine($"You are passing this class with a {letter}{sign}, congragulations!");
        }
        else
        {
                Console.WriteLine($"You are currently not passing with a {letter}{sign}. Don't give up though, it's not too late to improve your score");
        }
    }
}