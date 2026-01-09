using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess;
        int guessCount = 0;
        do
        {
            Console.Write("What is your guess? ");
            string magicGuess = Console.ReadLine();
            guess = int.Parse(magicGuess);
            guessCount += 1;


            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (number == guess)
            {
                Console.WriteLine("You guessed it!");
            }    
        } while (number != guess);
        Console.Write($"It only took you {guessCount} guesses, good job!");

    }
}