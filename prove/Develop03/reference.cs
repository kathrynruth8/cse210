using System;

public class Reference 
{
    // Variables
    // these are all attributes I dont know if verse text is needed
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;
    

    // two constructors to handle verse(s)
    public Reference()
    {
        _book = ;
        _chapter = ;
        _verseStart = ;
        _verseEnd = ;
    }
    public Reference(string inputBook, string inputChapter, string inputVerse)
    {
        _book = inputBook;
        _chapter = inputChapter;
        _verseStart = inputVerse;
        _verseEnd = ;
    }
    
    // methods/behaviors - not sure on these maybe need more
    public string GetReference()
    {
        string reference = $"{_book} {_Chapter}: {_verseStart}-{_verseEnd}";
        return reference
    }


    
}