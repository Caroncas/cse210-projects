using System;

class Program
{
    static void Main(string[] args)
    {
        //CREATIVE ADDITION: I made it so that the program won't show the same question twice in the reflection activity
        /*
        Menu System:
            1. Breathing
            2. Reflection
            3. Listing
            4. Quit
        */
        int keepGoing;
        int breathingIndex = 0;
        int reflectionIndex = 1;
        int listingIndex = 2;
        List<string> nameList = new List<string>{"Breathing Activity", "Reflection Activity", "Listing Activity"};
        List<string> descriptionList = new List<string>{"help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", "help you reflect on the good things in your life by having you list as many things as you can in a certain area."};
        do
        {
            Console.Clear();
            Console.WriteLine($"~ Mindfulness ~\n\t1. Start {nameList[breathingIndex]}\n\t2. Start {nameList[reflectionIndex]}\n\t3. Start {nameList[listingIndex]}\n\t4. Quit\n\nPlease select an option:");
            string keepGoingWord = Console.ReadLine();
            keepGoing = int.Parse(keepGoingWord);
            if (keepGoing == 1)
            {
                //Breathing
                BreathingActivity breathing = new BreathingActivity(nameList[breathingIndex], descriptionList[breathingIndex]);
                breathing.Run();
            }
            else if (keepGoing == 2)
            {
                //Reflection
                ReflectionActivity reflection = new ReflectionActivity(nameList[reflectionIndex], descriptionList[reflectionIndex]);
                reflection.Run();
            }
            else if (keepGoing == 3)
            {
                //Listing
                ListingActivity listing = new ListingActivity(nameList[listingIndex], descriptionList[listingIndex]);
                listing.Run();
            }
            else if (keepGoing == 4)
            {
                //Quit
                Console.WriteLine("Thank you for participating! Come back again soon!");
            }
            else
            {
                Console.WriteLine("Please select a valid number.");
            }
        } while (keepGoing != 4);
    }
}