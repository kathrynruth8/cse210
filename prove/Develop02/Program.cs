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
                string prompt = jp.GetPrompt();

                JournalEntry journalentry = new JournalEntry();
                journalentry.EntryNumber = entryId;
                journalentry.DateTime = dateInfo;
                journalentry.JournalPrompt = prompt;

                Console.WriteLine($"Here is your prompt: {prompt}");
                Console.WriteLine("*****");
                string userEntry = Console.ReadLine();
                entry._journalEntry = userEntry;

                journal._journal.Add(entry);
            }
// Display Journal Entries
            else if (action == 2)
            {
                journal.Display();
            }
// Load file
            else if (action == 3);
            {
                journal.LoadJournalFile();
            }    
// Save file
            else if (action == 4);
            {
                journal.SaveJournalFile();
            }
// Quit
            else if (action == 5);
            {
                Console.WriteLine("Thank you for using the Journal App! See you later alligator!");
            }
            else()
            {
                Console.Writeline("That was not a valid option, please try again.")
            }
    }
}
}