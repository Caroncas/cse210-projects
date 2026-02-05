public class ReflectionActivity : Activity
{
    //Start with message AYYAYAYAY
    //Give prompt, wait a few seconds to let them think
    //Give them reflection question relating to experience
    //Display a spinner when paused? 
    //Continue showing questions until # of seconds the user specified
    //End with dumb message BOOOO

    //Attributes:
    private int _count;
    private List<string> _reflectionPrompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _question = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through the experience?", "How can you keep this experience in mind in the future?"};

    //Methods:
    /*
        - Run
        - Get a random prompt
        - Get random question abt prompt (cycle through to eliminate them when used for each activity?)
        - Display the prompt
        - Display questions abt prompt & get answers? (User input?)
        - Private helper functions? 
    */
    public void Run()
    {
        Console.Clear();
    }

    //Constructor:
    public ReflectionActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }
}