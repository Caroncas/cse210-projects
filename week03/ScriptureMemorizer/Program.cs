using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Scripture Memorizer
        //***CREATIVE ADDITION***: I gave the user the option to input a scripture or they can receive one randomly chosen by the program from a text file.
        /*
        STORE a scripture (allow for multiple verses)
        CLEAR console screen then DISPLAY the complete scripture (each time)
        PROMPT user to press enter (continue) or type "q" (end program)
        HIDE random words (maybe 3-5 words? more?) then repeat CLEAR & DISPLAY step
            **Stretch Challenge: Only selecting words that are NOT yet hidden
        END program once all words are hidden
        */
        Reference reference;
        Scripture scripture;
        Random random = new Random();
        Console.Write("Welcome to the scripture Memorizer! \nWould you like to specify a scripture (1) or get a random one(2)? ");
        string specificOrRandom = Console.ReadLine();

        if (specificOrRandom == "1")
        {
        Console.WriteLine("Please enter the following information about the scripture you would like to memorize:");
        Console.Write("Book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Chapter number: ");
        string chapterString = Console.ReadLine();
        int chapter = int.Parse(chapterString);
        Console.Write("Would you like to memorize more than one verse in this scripture?(Y or N) ");
        string moreThanOne = Console.ReadLine();
        if (moreThanOne == "N" || moreThanOne == "n")
        {
            Console.Write("Verse number: ");
            string verseString = Console.ReadLine();
            int verse = int.Parse(verseString);
            reference = new Reference(bookName, chapter, verse);
        }
        else //if (moreThanOne == "Y")
        {
            Console.Write("First verse number: ");
            string verseFirstString = Console.ReadLine();
            int verse1 = int.Parse(verseFirstString);   
            Console.Write("Last verse number: ");
            string verseSecondString = Console.ReadLine();
            int verse2 = int.Parse(verseSecondString); 
            reference = new Reference(bookName, chapter, verse1, verse2);
        }
        Console.Write("Scripture: ");
        string scriptureText = Console.ReadLine();
        scripture = new Scripture(scriptureText);            
        }

        else
        {
            int randomNumber = random.Next(0, File.ReadLines("Scriptures.txt").Count());
            string lines = System.IO.File.ReadLines("Scriptures.txt").ElementAtOrDefault(randomNumber);
            if (lines == null)
            {
                reference = new Reference("Proverbs", 3, 5, 6);
                scripture = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."); 
            }
            else
            {
                string[] parts = lines.Split("~");
                if (parts.Length == 4)
                {
                    string bookName = parts[0];
                    string chapterString = parts[1];
                    int chapter = int.Parse(chapterString);
                    string verseString = parts[2];
                    int verse = int.Parse(verseString);
                    string text = parts[3];
                    reference = new Reference(bookName, chapter, verse);
                    scripture = new Scripture(text);
                }
                else
                {
                    string bookName = parts[0];
                    string chapterString = parts[1];
                    int chapter = int.Parse(chapterString);
                    string firstVerseString = parts[2];
                    int verse1 = int.Parse(firstVerseString);
                    string lastVerseString = parts[3];
                    int verse2 = int.Parse(lastVerseString);
                    string text = parts[4];
                    reference = new Reference(bookName, chapter, verse1, verse2);
                    scripture = new Scripture(text);
                }   
            }

        }

        string keepMemorizing;
        bool blackout;
        do
        {
            Console.Clear();
            Console.Write($"{reference.GetReferenceText()}\t");
            Console.WriteLine(scripture.DisplayAlteredScripture());
            blackout = scripture.Blackout();  
            if (blackout != true)
            {
                scripture.HideRandom();
                Console.Write("\nPress enter to continue or type 'quit' to finish: ");
                keepMemorizing = Console.ReadLine(); 
            }
            else
            {
                keepMemorizing = "quit";
            }            
        } while (keepMemorizing != "quit");
        Console.Clear();
        Console.WriteLine("Thank you for memorizing! Come back again!");
    }
}