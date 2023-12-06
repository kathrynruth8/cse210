public class Reference{
    //Tracks book, chapter, and verse or verses.

    // Declare variables
    private string Book;
    private int Chapter;
    private int Verse;
    private int EndVerse;
    private string ScriptureReference;

    // Constructor
    public Reference(){
        // Plain constructor
        Book = "John";
        Chapter = 3;
        Verse = 16;
    }
    public Reference(string book, int chapter, int verse){
        //Constructor for a scripture with only one verse
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse){
        //Constructor for a scripture with multiple verses
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }
    public Reference(string reference){
        ScriptureReference = reference;
    }

    // Methods
    public void SetReference(string reference){
        ScriptureReference = reference;
    }

    public void DisplayReference(){
        if (EndVerse > 0){
            Console.Write($"{Book} {Chapter}:{Verse}-{EndVerse}");
        }
        else if (Verse>0){
            Console.Write($"{Book} {Chapter}:{Verse}");
        }
        else{
            Console.Write($"{ScriptureReference}");
        }
        
    }

}