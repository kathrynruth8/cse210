public class Scripture
{
    private Reference ScriptureReference;
    private string MyScripture;
    private List<Word> Words = new List<Word>();
    private List<int> UsedRand = new List<int>();
    private Random Rand = new Random();

    public Scripture(Reference reference, string scripture)
    {
        ScriptureReference = reference;
        MyScripture = scripture;
        ConvertToList(MyScripture);
    }

    public void DisplayScripture()
    {
        ScriptureReference.DisplayReference();
        foreach (Word word in Words)
        {
            Console.Write(" ");
            word.DisplayWord();
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        int randI;
        do
        {
            randI = Rand.Next(0, Words.Count);
        } while (UsedRand.Contains(randI));

        Words[randI].Hide();
        UsedRand.Add(randI);
    }

    public string IsCompletelyHidden()
    {
        if (UsedRand.Count == Words.Count)
        {
            return "exit";
        }
        else
        {
            return "next";
        }
    }

    private void ConvertToList(string scripture)
    {
        string[] text = scripture.Split(' ');
        foreach (string word in text)
        {
            Words.Add(new Word(word));
        }
    }
}
