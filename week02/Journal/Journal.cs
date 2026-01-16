//Stores a LIST of journal entries
//Also handles file SAVE and fiel LOAD actions
using System.Security.Authentication.ExtendedProtection;
using System.IO;
using System.ComponentModel;

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
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        //prints each entry from the list
        foreach (Entry entry in _entries)
        {
            string wholeEntry = "Date: " + entry._dateTime + " - Prompt: " + entry._prompt + "\n" + entry._entry;
            Console.WriteLine(wholeEntry);
            Console.WriteLine();
        }

    }
    public void FileSave(string fileName)
    {
        //figure this out dum dum
        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        //if you don't want it overwriting every entry use:
        // using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Entry entry in _entries)
            {
                string fileSaveEntry = entry._dateTime + "~" + entry._prompt + "~" + entry._entry;
                outputFile.WriteLine(fileSaveEntry);
            }
        }
    }
    public void FileLoad(string fileName)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry fileLoadEntry = new Entry();
            string[] parts = line.Split("~");
            if (parts.Length != 3) continue;

            fileLoadEntry._dateTime = parts[0];
            fileLoadEntry._prompt = parts[1];
            fileLoadEntry._entry = parts[2];
            // string newEntry = fileSaveEntry._dateTime + fileSaveEntry._prompt + "~" + fileSaveEntry._entry;
            _entries.Add(fileLoadEntry);
        }
        Console.WriteLine($"DEBUG: Loaded {_entries.Count} entries");
    }
}
