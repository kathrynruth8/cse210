using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0;
        Console.WriteLine("**** Welcome to the Journal App ****");
        
        Journal journal = new Journal();
        JournalPrompt journalPrompt = new JournalPrompt();

        while (action != 5)
        {
            action = Choices();

// Write Journal Entry
            if (action == 1)
            {
                string entryId = GetEntryId();
                string dateInfo = GetDateTime();
                string prompt = journalPrompt.GetPrompt();

                JournalEntry journalEntry = new JournalEntry();
                journalEntry.EntryNumber = entryId;
                journalEntry.DateTime = dateInfo;
                journalEntry.JournalPrompt = prompt;

                Console.WriteLine($"Here is your prompt: {prompt}");
                Console.WriteLine("*****");
                string userEntry = Console.ReadLine();
                journalEntry.JournalEntryText = userEntry; // Assign user entry to the journal entry text

                journal.journal.Add(journalEntry);   
            }
// Display Journal Entries
            else if (action == 2)
            {
                journal.Display();
            }
// Load file
            else if (action == 3)
            {
                journal.LoadJournalFile();
            }    
// Save file
            else if (action == 4)
            {
                string userFileName = journal.GetFileName(); // Retrieve the file name
                if (!string.IsNullOrEmpty(userFileName))
                {
                    journal.SaveJournalFile(userFileName); // Pass the file name to SaveJournalFile method
                }
                else
                {
                    Console.WriteLine("Invalid file name. Please enter a valid file name.");
                }
            }
// Quit
            else if (action == 5)
            {
                Console.WriteLine("Thank you for using the Journal App! See you later alligator!");
            }
            else
            {
                Console.WriteLine("That was not a valid option, please try again.");
            }
    }
}
static int Choices()
    {
        string Choices = @"
        Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? ";

        Console.Write(Choices);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput); // Parse user input to int
        return action;
    }

static string GetDateTime() // Change return type to string
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
static void AddJournalEntry(string userEntry) // Accept user entry as argument
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, userEntry + Environment.NewLine); // Append user entry to the file
    }


    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }

}