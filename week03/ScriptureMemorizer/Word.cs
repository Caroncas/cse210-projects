//keeps track of single word and whether it's shown or hidden
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Diagnostics.CodeAnalysis;

public class Word
{
    //Attributes (**should all be private):
    //_text (string)
    //_blackoutWord (bool)
    private string _text;
    private bool _blackoutWord;
    
    //Methods:
    //HideWord (return = void)
    //ShowUnderlinedWord (return = void)
    //CheckWord (return = bool)
    //GetText (return = string)
    public void HideWord()
    {
        //changes _blackoutWord status of the class
    }
    public string ShowUnderlinedWord()
    {
        //returns underlined version of the word to print
        // int wordLength.Length(_text);
        //it will need to iterate through the same length as the word (not including punctuation?)
        //it will add _ onto the end of a predetermined thing?
        //maybe you can just alter the _text instead of returning a string?
        return "";
    }
    public bool CheckWord()
    {
        if (_blackoutWord == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string GetText()
    {
        string emptyForNow = "";
        return emptyForNow;
    }

    //Constructors:
    public Word(string singleWord)
    {
        _text = singleWord;
        _blackoutWord = false;
    }
}