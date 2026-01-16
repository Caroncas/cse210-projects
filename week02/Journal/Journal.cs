//Stores a LIST of journal entries
//Also handles file SAVE and fiel LOAD actions
using System.Security.Authentication.ExtendedProtection;

public class Journal()
{
    /*Attributes:
        -_entries
    */
    public List<Entry> _entries = new List<Entry>();
    /*Method:
        -AddEntry(Entry):void
        -Display():void
        -FileSave(string):void
        -FileUpload(string):void
    */
    public void AddEntry(Entry newEntry)
    {
        //save the file to the list
        Journal journalList = new Journal();
        journalList._entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        //prints each entry from the list
        foreach (Entry entry in _entries)
        {
            string newEntry = "Date: " + entry._dateTime + " - Prompt: " + entry._prompt + "\n" + entry._entry;
            Console.WriteLine(newEntry);
        }

    }
    public void FileSave(string fileName)
    {
        //figure this out dum dum
    }
    public void FileLoad(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry fileSaveEntry = new Entry();
            string[] parts = line.Split("~");
            fileSaveEntry._dateTime = parts[0];
            fileSaveEntry._prompt = parts[1];
            fileSaveEntry._entry = parts[2];
            string newEntry = fileSaveEntry._dateTime + "~" + fileSaveEntry._prompt + "~" + fileSaveEntry._entry;
            _entries.Add(fileSaveEntry);
        }
    }
}
