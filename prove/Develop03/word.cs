public class Word
{
    private bool IsHidden = false;
    private string MyWord;

    public Word(string word)
    {
        MyWord = word;
    }

    public void DisplayWord()
    {
        if (IsHidden)
        {
            foreach (char letter in MyWord)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(MyWord);
        }
    }

    public void Hide()
    {
        IsHidden = true;
    }
}
