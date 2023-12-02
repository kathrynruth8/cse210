using System;

class Program
{
    static void Main(string[] args)
    {
        int[] validNumbers = {1, 2, 3, 4, 5};
        int action = 0;
        Console.WriteLine("**** Welcome to the Journal App ****");
        // Create new journal reference/list
        Journal journal = new Journal();
        JournalPrompt journalPrompt = new JournalPrompt();

        while (action != 5)
        {
            // Ask for user input (1-5)
            //Call Choices
            action = Choices();

// Write Journal Entry
            if (action == 1)
            {
                string entryId = GetEntryId();
                string dateInfo = GetDateTime();
                string prompt = journalPrompt.GetPrompt();

                JournalEntry journalentry = new JournalEntry();
                journalentry.EntryNumber = entryId;
                journalentry.DateTime = dateInfo;
                journalentry.JournalPrompt = prompt;

                Console.WriteLine($"Here is your prompt: {prompt}");
                Console.WriteLine("*****");
                string userEntry = Console.ReadLine();
                entry.journalEntry = userEntry;

                journal.journal.Add(entry);
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
                journal.SaveJournalFile();
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
        int action = 0;
        return action;
}

static int GetDateTime()
{
    DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
}
static void AddJournalEntry()
    // Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }

}