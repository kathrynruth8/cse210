public class JournalEntry 
{
    public string EntryNumber { get; set; } = "";
    public string DateTime { get; set; } = "";
    public string JournalPrompt { get; set; } = "";
    public string JournalEntryText { get; set; } = "";
    public string JournalFile { get; set; } = "";


    public JournalEntry()
    {

    }

    public string GetDisplayInfo()
    {
        return $"\nEntry Number: {EntryNumber}\nDate: {DateTime}\nPrompt: {JournalPrompt}\nEntry: {JournalEntryText}";
    }


}
