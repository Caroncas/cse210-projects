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
    }

    //Constructor:
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
}