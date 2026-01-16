using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        //CREATIVE ADDITION: Instead of ONLY providing a prompt I let them choose between a provided prompt, including their own prompt, or simply writing about their day.
        /* 1. New Journal Entry 
                You show them a random prompt (probably from a list you created)
           2. Display Journal Entries
                You iterate through all journal entries and DISPLAY them
           3. Save Journal to a File
                Prompt user for a filename (where they want it saved) have it save ALL prompts to that location
                **My question is, do they need to be saved as individual files each or just into one big file?
           4. (UP)Load Journal from File
                Ask for a file name (Direct Path?) and load journal (replacing any currently stored entries)
           5. Quit
        ** Must provide a list of (at least 5) prompts & MENU allowing user to choose option
        */
        string userInput;
        string userEntry;
        Journal journal = new Journal();
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
                Console.WriteLine("Prompt Options:\n\ta. random prompt \n\tb. original prompt\n\tc. write about today");
                string promptOption = Console.ReadLine();
                if (promptOption == "a")
                {
                    Entry entry1 = new Entry();
                    entry1.Display();
                    userEntry = Console.ReadLine();
                    entry1._entry = userEntry;
                    DateTime todayDate = DateTime.Today;
                    string formattedDate = DateTime.Now.ToString("MM/dd/yyyy");
                    entry1._dateTime = formattedDate;

                    journal.AddEntry(entry1);
                }

                else if (promptOption == "b")
                {
                    Entry entry2 = new Entry();
                    Console.Write("Write Prompt Here: ");
                    string userPrompt = Console.ReadLine();
                    entry2._prompt = userPrompt;
                    Console.Write("Write Journal Entry Here: ");
                    userEntry = Console.ReadLine();
                    entry2._entry = userEntry;
                    DateTime todayDate = DateTime.Today;
                    string formattedDate = DateTime.Now.ToString("MM/dd/yyyy");
                    entry2._dateTime = formattedDate;

                    journal.AddEntry(entry2);
                }

                else if (promptOption == "c")
                {
                    Entry entry3 = new Entry();
                    entry3._prompt = "How was my day?";
                    Console.WriteLine($">{entry3._prompt}");
                    userEntry = Console.ReadLine();
                    entry3._entry = userEntry;
                     DateTime todayDate = DateTime.Today;
                    string formattedDate = DateTime.Now.ToString("MM/dd/yyyy");
                    entry3._dateTime = formattedDate;

                    journal.AddEntry(entry3);
                }

                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            else if (userInput == "2")
            {
                //display journal entries
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                //load journal from file
                Console.Write("What is the name of the file you would like to read from? ");
                string fileName = Console.ReadLine();
                journal.FileLoad(fileName);
            }
            else if (userInput == "4")
            {
                //save all entries to file
                Console.Write("What is the name of the file you would like to save to? ");
                string fileName = Console.ReadLine();
                journal.FileSave(fileName);

            }
            else if (userInput != "5")
            {
                Console.WriteLine("Please enter a valid input.\n");
            }

        } while (userInput != "5");
        Console.WriteLine("Thank you!");
    }
}