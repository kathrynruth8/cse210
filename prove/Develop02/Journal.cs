public class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string _journalName;

    public Journal() {}

    public void DisplayEntries(){
        Console.Writeline("\n********** Journal Entries **********");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n******************** End ********************");
        
    }

    public string GetFileName() {
        Console.Write("What is your file name?");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        return _userFileName;
    }

    public void CreateJournalFile()
    {
        _userFileName = GetFileName();
        // Check for if file exists
        if (!File.Exists(_userFileName)) {
            Console.WriteLine($"*** {_userFileName} has been created! ***");
            Console.WriteLine("*** Entry Saved ***");
            SaveJournalFile(_userFileName);
        } else {
            Console.WriteLine($"*** {_userFileName} already exists ***");
            Console.WriteLine($"*** Entry added ***");
            AppendJournalFile(_userFileName);
        }
    }

    public void SaveJournalFile(string _userFileName) {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string _userFileName) {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadJournalFile() {
        _userFileName = GetFileName();

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                JournalEntry entry = new JournalEntry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];

                _journal.Add(entry);
            }
        }
    }
    public void CreateJSON(string userInput)
    // Method to create a JSON file 
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (JournalEntry journalEntry in _journal)
        {
            _data.Add(new JsonItem()
            {
                ID = journalEntry._entryNumber,
                Date = journalEntry._dateTime,
                Prompt = journalEntry._journalPrompt,
                Entry = journalEntry._journalEntry
            });
        }

        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

}