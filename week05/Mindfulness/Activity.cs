public class Activity
{
    //Start with a common message providing name of activity
    //Description
    //Asks for & sets duration (in seconds)
    //Tells user to prepare to begin then pauses for several seconds

    //Runs other activity

    //Ends saying GOOD JOB
    //Pause, tell them which activity was completed and for how long
    //Pauses for several seconds

    //**Whenever paused it will have an animation
    //Normal interface
    //Attributes:
    private string _nameOfActivity;
    private string _description;
    protected int _duration;

    //Methods:
    /*
        - Display starting Message
        - Display ending Message
        - Pause w/ spinner for certain seconds
        - Pause w/ countdown timer
    */
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_nameOfActivity}!");
        Console.WriteLine($"This activity will {_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done! ");
        ShowSpinner(5);
        Console.WriteLine($"\n\nYou have completed {_duration} seconds of the {_nameOfActivity}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> animation = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\"};
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string character = animation[i];
            Console.Write(character);
            Thread.Sleep(750);
            Console.Write("\b \b");

            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            if (i < 9)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            else
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
            }
        }
    }

    //Constructor:
    public Activity(string name, string description)
    {
        _nameOfActivity = name;
        _description = description;
    }
}