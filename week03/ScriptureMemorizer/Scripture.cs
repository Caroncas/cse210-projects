//TRACKs reference & text of scripture.
//Can HIDE words & GET the rendered text display
using System.Net.Sockets;
using System.Runtime.CompilerServices;

public class Scripture
{
    //Attributes (**should all be private):
    //_scriptureReference (Reference)
    //_words (List<Word>)
    private List<Word> _words = new List<Word>();
    /*Methods:
    HideRandom (return = void): arg = hideNumber(int)
    DisplayAlteredScripture (return = string)
        Text with some of the messed up words
        You need to be able to see when ALL of the words are covered up
    Blackout (return = bool)*/
    Random random = new Random();
    public void HideRandom()
    {
        //basically I'll have to have a random number generator in Program
        //have it call this 3 times each enter
        //HideRandom will call the list and find the word at i
        //then it will call Hide word from Word
        //it will replace i in the list with the new word
        int hidingThreeWords = 0;
        int listTotal = _words.Count();
        while (hidingThreeWords < 3)
        {
            int randomNumber = random.Next(0, listTotal);
            bool alreadyDone = _words[randomNumber].CheckWord();
            if (alreadyDone == false)
            {
                _words[randomNumber].HideWord();
                _words[randomNumber].ShowUnderlinedWord();
                hidingThreeWords += 1;
            }
            else if (hidingThreeWords < 3)
            {
                bool isComplete = Blackout();
                if (isComplete == true)
                {
                    break;
                }
            }
        }
        
    }
    public string DisplayAlteredScripture()
    {
        //how the heck to I print out a list again? Is there a way to add it to a variable? I'm really not sure...
        //it will have to go through each checking if it is supposed to be blacked out.
        //if yes, it will call ShowUnderlinedWord from Word to write it underlined
        string stringToPrint = "";
        foreach (Word word in _words)
        {
            string extractedWord = word.GetText();
            stringToPrint += extractedWord + " ";
            // in case I change the show underlined word back to printing a string
            // if (word.CheckWord() == false)
            // {
            //     stringToPrint += word + " ";
            // }
            // else
            // {
            //     string blackedOutWord = word.ShowUnderlinedWord();
            //     stringToPrint += blackedOutWord + " ";
            // }
        }
        return stringToPrint;
    }
    public bool Blackout()
    {
        bool blackedOut = false;

        foreach (Word word in _words)
        {
            bool wordChecked = word.CheckWord();
            if (wordChecked == false)
            {
                blackedOut = false;
                break;
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