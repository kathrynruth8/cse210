public class Journal
{
    public List<JournalEntry> journal = new List<JournalEntry>();
    private string userFileName; // Added declaration for file handling

    public Journal() {}


    public void Display()
    {
        foreach (JournalEntry journalEntry in journal)
        {
            Console.WriteLine(journalEntry.GetDisplayInfo()); // Use GetDisplayInfo method from JournalEntry
        }
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

    public void SaveJournalFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry journalEntry in journal)
            {
                outputFile.WriteLine($"{journalEntry.EntryNumber}; {journalEntry.DateTime}; {journalEntry.JournalPrompt}; {journalEntry.JournalEntryText}");
            }
        }
    }

    public void AppendJournalFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            foreach (JournalEntry journalEntry in journal)
            {
                outputFile.WriteLine($"{journalEntry.EntryNumber}; {journalEntry.DateTime}; {journalEntry.JournalPrompt}; {journalEntry.JournalEntryText}");
            }
        }
    }

    public void LoadJournalFile()
    {
        userFileName = GetFileName(); // Assign userFileName using GetFileName method

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
                entry.JournalEntryText = entries[3];

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