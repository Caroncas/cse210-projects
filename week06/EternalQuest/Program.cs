using System;

class Program
{
    static void Main(string[] args)
    {
        //Gamifications **Jazz Hands**
        /*
        Menu Options:
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit
        Select a choice from the menu:
        */
        int menuNumber;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            menuNumber = int.Parse(menuChoice);
            
            if (menuNumber == 1)
            {
                //Create New Goal
                /*
                    1. Simple Goal (one time)
                    2. Eternal Goal (never complete, but they get points still)
                    3. Checklist Goal (complete it x amount of times)
                */
                Console.Clear();
                Console.WriteLine("Goal Options:");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal");
                Console.WriteLine("\t3. Checklist Goal");
                Console.Write("What kind of goal would you like to create? ");
                string goalChoice = Console.ReadLine();
                int goalNumber = int.Parse(goalChoice);

                if (goalNumber == 1)
                {
                    
                }
                else if (goalNumber == 2)
                {
                    
                }
                else if (goalNumber == 3)
                {
                    
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
            else if (menuNumber == 2)
            {
                //List Goals
            }
            else if (menuNumber == 3)
            {
                //Save Goals
            }
            else if (menuNumber == 4)
            {
                //Load Goals
            }
            else if (menuNumber == 5)
            {
                //Record Event
            }
            else if (menuNumber != 6)
            {
                Console.WriteLine("Please enter a valid menu number.\n");
            }
        }
        while (menuNumber != 6);
    }
}