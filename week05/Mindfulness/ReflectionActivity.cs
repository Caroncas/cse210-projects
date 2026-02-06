using System.Security.Cryptography;

public class ReflectionActivity : Activity
{
    //Start with message AYYAYAYAY
    //Give prompt, wait a few seconds to let them think
    //Give them reflection question relating to experience
    //Display a spinner when paused? 
    //Continue showing questions until # of seconds the user specified
    //End with dumb message BOOOO

    //Attributes:
    private List<int> _usedQuestion = new List<int>();
    private List<string> _reflectionPrompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through the experience?", "How can you keep this experience in mind in the future?"};

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
        DisplayStartingMessage();
        
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they relate to this experience.\nYou may begin in: ");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
        }

        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptTotal = _reflectionPrompts.Count();
        int randomNumber = random.Next(0, promptTotal);
        string prompt = _reflectionPrompts[randomNumber];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionTotal = _questions.Count();
        int randomNumber;
        string question = "";
        do
        {
            randomNumber = random.Next(0, questionTotal);
            if (!_usedQuestion.Contains(randomNumber))
            {
                question = _questions[randomNumber];
            }
        } while (_usedQuestion.Contains(randomNumber));
        _usedQuestion.Add(randomNumber);
        return question;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---\n");
    }
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"\n\t> {question} ");
    }

    //Constructor:
    public ReflectionActivity(string name, string description) : base(name, description)
    {
        
    }
}