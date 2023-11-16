using System;

public class Journal;
{
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string _journalName;

    public Journal() {
    }

    public DisplayEntries(){
        Console.Writeline("\n********** Journal Entries **********")
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n******************** End ********************")
        
    }

    public void CreateJournalFile()
    {
        Console.Write("What is your file name?")
    }
}