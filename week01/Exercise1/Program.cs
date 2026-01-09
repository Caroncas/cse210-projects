using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string given = Console.ReadLine();
        Console.Write("What is your last name? ");
        string surname = Console.ReadLine();

        Console.Write($"Your name is {surname}, {given} {surname}.");
    }
}