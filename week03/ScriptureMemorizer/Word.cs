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
        _blackoutWord = true;
    }
    public void ShowUnderlinedWord()
    {
        //returns underlined version of the word to print
        // int wordLength.Length(_text);
        //it will need to iterate through the same length as the word (not including punctuation?)
        //it will add _ onto the end of a predetermined thing?
        //maybe you can just alter the _text instead of returning a string?
        List<char> specialCharacters = new List<char> {',', '.', '-', ';', ':'};
        string blackedOutWord = "";
        char newCharacter;
        bool characterIsSpecial = false;
        char specialCharacter = ' ';
        foreach (char character in _text)
        {
            foreach (char specChar in specialCharacters)
            {
                if (character == specChar)
                {
                    characterIsSpecial = true;
                    specialCharacter = specChar;
                    break;
                }
            }
            if (characterIsSpecial != true)
            {
                    newCharacter = '_';
                    blackedOutWord += newCharacter;
            }
            else
            {
                blackedOutWord += specialCharacter;
            }
        }
        _text = blackedOutWord;

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
        string word = _text;
        return word;
    }
    //Constructors:
    public Word(string singleWord)
    {
        _text = singleWord;
        _blackoutWord = false;
    }
}