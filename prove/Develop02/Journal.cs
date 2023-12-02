public class Journal
{
    public List<JournalEntry> journal = new List<JournalEntry>();
    private string journalName;

    public Journal() {}

    public void Display(){
        Console.WriteLine("\n********** Journal Entries **********");
        foreach (JournalEntry journalEntry in journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n******************** End ********************");
        
    }

    public string GetFileName() {
        Console.Write("What is your file name?");
        string userInput = Console.ReadLine();
        userFileName = userInput + ".txt";
        return userFileName;
    }

    public void CreateJournalFile()
    {
        userFileName = GetFileName();
        // Check for if file exists
        if (!File.Exists(userFileName)) {
            Console.WriteLine($"*** {userFileName} has been created! ***");
            Console.WriteLine("*** Entry Saved ***");
            SaveJournalFile(userFileName);
        } else {
            Console.WriteLine($"*** {userFileName} already exists ***");
            Console.WriteLine($"*** Entry added ***");
            AppendJournalFile(userFileName);
        }
    }

    public void SaveJournalFile(string userFileName) {
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            foreach (JournalEntry journalEntry in journal)
            {
                outputFile.WriteLine($"{JournalEntry.EntryNumber}; {JournalEntry.DateTime}; {JournalEntry.JournalPrompt}; {JournalEntry.JournalEntry}");
            }
        }
    }

    public void AppendJournalFile(string userFileName) {
        using (StreamWriter outputFile = new StreamWriter(userFileName, append: true))
        {
            foreach (JournalEntry journalEntry in journal)
            {
                outputFile.WriteLine($"{JournalEntry.EntryNumber}; {JournalEntry.DateTime}; {JournalEntry.JournalPrompt}; {JournalEntry.JournalEntry}");
            }
        }
    }

    public void LoadJournalFile() {
        GetFileName() = userFileName;

        if (File.Exists(userFileName))
        {
            List<string> readText = File.ReadAllLines(userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                JournalEntry entry = new JournalEntry();

                entry.EntryNumber = entries[0];
                entry.DateTime = entries[1];
                entry.JournalPrompt = entries[2];
                entry.JournalEntry = entries[3];

                journal.Add(entry);
            }
        }
    }
    // public void CreateJSON(string userInput)
    // // Method to create a JSON file 
    // {
    //     string fileName = userInput + ".json";
    //     List<JsonItem> data = new List<JsonItem>();

    //     foreach (JournalEntry journalEntry in journal)
    //     {
    //         data.Add(new JsonItem()
    //         {
    //             ID = journalEntry.entryNumber,
    //             Date = journalEntry.dateTime,
    //             Prompt = journalEntry.journalPrompt,
    //             Entry = journalEntry.journalEntry
    //         });
    //     }
    // }

}