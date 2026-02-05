using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Menu System:
            1. Breathing
            2. Reflection
            3. Listing
            4. Quit
        */
        int keepGoing = -1;
        do
        {
            Console.Clear();
            Console.WriteLine("~ Meditation ~\n\t1. Breathing\n\t2. Reflection\n\t3. Listing\n\t4. Quit\n\nPlease select a number:");
            string keepGoingWord = Console.ReadLine();
            keepGoing = int.Parse(keepGoingWord);
            if (keepGoing == 1)
            {}
            else if (keepGoing == 2)
            {}
            else if (keepGoing == 3)
            {}
            else if (keepGoing == 4)
            {}
            else
            {
                Console.WriteLine("Please select a valid number.");
            }
        } while (keepGoing != 4);
    }
}