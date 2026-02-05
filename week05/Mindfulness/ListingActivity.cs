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

    //Methods:
    /*
        - Run
        - Get random prompt
        - Get list of responses from user (into CSV?? TXT??? quien sabe)
    */
     public void Run()
    {
        Console.Clear();
    }

    //Constructors:
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
}