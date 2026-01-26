//TRACKs the book, chapter, & verse info
//Uh so how is this different from scripture?
//Is it like a list that will hold the scripture for later use?
public class Reference
{
    //Attributes (**should all be private):
    //_book (string)
    //_chapter (int)
    //_verse (int)
    //_endVerse (int) (In the case of having multiple verses of scripture)
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    //Methods:
    public string GetReferenceText()
    {
        string scriptureReference;
        if (_endVerse == 0)
        {
            scriptureReference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            scriptureReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return scriptureReference;
    }
    //Constructors:
    public Reference(string bookName, int chapter, int verse)
    {
        _book = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string bookName, int chapter, int verse, int endVerse)
    {
        _book = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
}