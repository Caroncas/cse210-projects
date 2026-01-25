//TRACKs reference & text of scripture.
//Can HIDE words & GET the rendered text display
using System.Net.Sockets;

public class Scripture
{
    //Attributes (**should all be private):
    //_scriptureReference (Reference)
    //_words (List<Word>)
    private List<Word> _words = new List<Word>();
    
    //Methods:
    //HideRandom (return = void): arg = hideNumber(int)
    //DisplayAlteredScripture (return = string)
        //Text with some of the messed up words
        //You need to be able to see when ALL of the words are covered up
    //Blackout (return = bool)
    public void HideRandom(int hideNumber)
    {
        //basically I'll have to have a random number generator in Program
        //have it call this 3 times each enter
        //HideRandom will call the list and find the word at i
        //then it will call Hide word from Word
        //it will replace i in the list with the new word
    }
    public string DisplayAlteredScripture()
    {
        //how the heck to I print out a list again? Is there a way to add it to a variable? I'm really not sure...
        //it will have to go through each checking if it is supposed to be blacked out.
        //if yes, it will call ShowUnderlinedWord from Word to write it underlined
        return "";
    }
    public bool Blackout()
    {
        bool blackedOut = false;

        foreach (Word word in _words)
        {
            bool wordChecked = word.CheckWord();
            if (wordChecked != false)
            {
                blackedOut = false;
            }
            else
            {
                blackedOut = true;
            }
        }
        return blackedOut;
    }

    //Constructors:
    public Scripture(string text)
    {
        foreach (string word in text.Split( ))
        {
            Word newWord = new Word(word);
            //now you've got to assign the bool variable of hidden = false  
            _words.Add(newWord);
        }
    }
}