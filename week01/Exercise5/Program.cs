using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int squared = SquareNumber(favNumber);
        DisplayResult(squared, name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(int squared, string name)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squared}.");
    }
}