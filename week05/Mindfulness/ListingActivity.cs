public class ListingActivity : Activity
{
    //Begin with message NOT DOING THIS TODAY
    //Random Prompt
    //Give them a countdown to begin thinking
    //Prompt them to list items, as many as possible
    //Display # of items listed
    //End with dumb message cuz we're mad at life rn
    
    //Attributes:
    private List<string> _listingPrompts = new List<string>{"Who are people you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?", "What songs have resonated with you this week?", "What foods have tasted especially good this week?"};
    private int _count;

    //Methods:
    /*
        - Run
        - Get random prompt
        - Get list of responses from user (into CSV?? TXT??? quien sabe)
    */
    static Random random = new Random();
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        _count = GetList().Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndMessage();
    }
    public void GetRandomPrompt()
    {
        int totalPrompts = _listingPrompts.Count();
        int randomNumber = random.Next(0, totalPrompts);
        Console.WriteLine(_listingPrompts[randomNumber]);
    }
    public List<string> GetList()
    {
        List<string> responseList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(" > ");
            string item = Console.ReadLine();
            responseList.Add(item);
        }
        return responseList;
    }

    //Constructors:
    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }
}