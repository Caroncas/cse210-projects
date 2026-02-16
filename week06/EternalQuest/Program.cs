using System;

class Program
{
    static void Main(string[] args)
    {
        //CREATIVE ADDITION: I added a counter in the Eternal Goal that will tell you how many times you've accomplished the goal throughout its lifetime. I also added the functionality to remove a goal if you deem it no longer relevant.
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
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}