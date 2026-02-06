public class BreathingActivity : Activity
{
    //Begin with message YAY
    //User is shown a series of "Breathe in" and "Breathe out" messages
    //After Breath messages, program should pause for multiple seconds and show a countdown
    //Follow user specified duration
    //End with message YAY

    //Attributes:
    //no

    //Methods:
    /*
        - Run
    */
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            TimeSpan timeRemaining = endTime - DateTime.Now;
            if (timeRemaining.TotalSeconds <= 5)
            {
                Console.Write("\n\nBreathe in... ");
                ShowCountdown(2);
                Thread.Sleep(1000);
                Console.Write("\nNow breathe out... ");
                ShowCountdown(2);
                Thread.Sleep(1000);
            }
            else
            {
                Console.Write("\n\nBreathe in... ");
                ShowCountdown(4);
                Thread.Sleep(1000);
                Console.Write("\nNow breathe out... ");
                ShowCountdown(4);
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("\n");
        DisplayEndMessage();
    }

    //Constructor:
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
}