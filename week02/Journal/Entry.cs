//Represents a SINGLE journal entry
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

//DateTime today = DateTime.Today;
public class Entry()
{
    /*Attributes:
        -_prompt
        -_entry
        -_dateTime
    */
    public string _entry;
    public string _prompt;
    public string _dateTime;

    /*Method:
        -Display():void
        Displaying prompt
        ** if you decide to do that optional thing you were talking about it would be good to create a separate method for it
           so that it doesn't choose a different random prompt.
    */
    public void Display()
    {
        PromptGenerator prompt = new PromptGenerator();
        string _prompt = prompt.DisplayRandom();
        Console.WriteLine($">{_prompt}");
    }
}