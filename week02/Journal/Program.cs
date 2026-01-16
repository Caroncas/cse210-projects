using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        /* 1. New Journal Entry 
                You show them a random prompt (probably from a list you created)
           2. Display Journal Entries
                You iterate through all journal entries and DISPLAY them
           3. Save Journal to a File
                Prompt user for a filename (where they want it saved) have it save ALL prompts to that location
                **My question is, do they need to be saved as individual files each or just into one big file?
           4. (UP)Load Journal from File
                Ask for a file name (Direct Path?) and load journal (replacing any currently stored entries)
            5** for a bonus add on you could let them write a custom prompt or simply write about their day
            5. Quit
        ** Must provide a list of (at least 5) prompts & MENU allowing user to choose option
        */
        string userInput;
        string userEntry;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display All Journal Entries");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save to File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Entry entry1 = new Entry();
                Journal journal = new Journal();
                entry1.Display();
                userEntry = Console.ReadLine();
                entry1._entry = userEntry;

                DateTime todayDate = DateTime.Today;
                string formattedDate = DateTime.Now.ToString("MM/dd/yyy");
                entry1._dateTime = formattedDate;

                journal.AddEntry(entry1);
            }
            else if (userInput == "2")
            {
                //display journal entries THEY DON'T SEEM TO BE SAVING PROPERLY, YOU'LL HAVE TO FIGURE THAT OUT.
                Journal journal = new Journal();
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                //prompt for filename, save all entries to location
            }
            else if (userInput == "4")
            {
                //load journal from file
                Journal journal = new Journal();
                Console.Write("What is the name of the file you would like to read from? ");
                string fileName = Console.ReadLine();
                journal.FileLoad(fileName);

            }
            else if (userInput != "5")
            {
                Console.WriteLine("Please enter a valid input.\n");
            }

        } while (userInput != "5");
        Console.WriteLine("Thanks for playing!");
    }
}