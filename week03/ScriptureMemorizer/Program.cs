using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Scripture Memorizer
        /*
        STORE a scripture (allow for multiple verses)
        CLEAR console screen then DISPLAY the complete scripture (each time)
        PROMPT user to press enter (continue) or type "q" (end program)
        HIDE random words (maybe 3-5 words? more?) then repeat CLEAR & DISPLAY step
            **Stretch Challenge: Only selecting words that are NOT yet hidden
        END program once all words are hidden
        */
        Reference reference = new Reference("Proverbs", 3, 5, 6);
            // you can make this user input to make it more manageable later if you want
        Console.WriteLine(reference.GetReferenceText());
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart and lena not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        string keepMemorizing ="";
        bool blackout = scripture.Blackout();
        do
        {
            Console.WriteLine("Press enter to continue or type 'q' to finish: ");
            keepMemorizing = Console.ReadLine();   
            
        } while (blackout != true || keepMemorizing != "q");
    }
}