using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        //tracking date, length in time
        // - Running: distance
        // - Cycling: speed
        // - Swimming: # of laps (50 meters)

        //Create 1 of each activity and add them to an Activity list.
        //** Distance in MILES
        List<Activity> activities = new List<Activity>();

        DateTime startTime = DateTime.Now;
        string formattedDate = startTime.ToString("dd MMM yyyy");

        Running running1 = new Running(45, formattedDate, 5.45);
        activities.Add(running1);

        Cycling cycling2 = new Cycling(65, formattedDate, 19.8);
        activities.Add(cycling2);

        Swimming swimming3 = new Swimming(20, formattedDate, 100);
        activities.Add(swimming3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}\n");
        }
    }
}