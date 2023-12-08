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

    public static int HideRandomWords(List<Word> words)
{
        Random rand = new Random();
        int wordsToHide = rand.Next(1, 4); // Random number of words to hide between 1 and 3
        int wordsHidden = 0;

        while (wordsHidden < wordsToHide)
        {
            int randomIndex = rand.Next(words.Count);
            if (!words[randomIndex].IsHidden)
            {
                words[randomIndex].Hide();
                wordsHidden++;
            }
            else if (AllWordsHidden(words))
            {
                break; // If all words are already hidden, exit the loop
            }
        }

        return wordsHidden;
    }
private static bool AllWordsHidden(List<Word> words)
    {
        foreach (var word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}