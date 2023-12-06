public class Scripture{
    //Tracks reference and text of the scripture, hides words in the scripture, and displays scripture.

    // Declare variables
    private Reference ScriptureReference = new Reference();
    private string MyScripture;
    //private Boolean IsHidden = false;
    private List<Word> Words = new List<Word>();
    private Word Word = new Word();
    //private Random Rand = new Random();
    private int RandI;
    //private bool Used = true;
    private List<int> UsedRand = new List<int>();

    // Constructor
    public Scripture(){
        ScriptureReference.SetReference("John 3:16");
        MyScripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        ConvertToList(MyScripture);
    }

    public Scripture(string reference, string scripture){
        ScriptureReference.SetReference(reference);
        MyScripture = scripture;
        ConvertToList(MyScripture);
    }

    // Methods
    public void DisplayScripture(){
        /*
        Method: Displays Scripture

        Variables: accepts no variables

        Returns: nothing
        */
        ScriptureReference.DisplayReference();
        //Console.Write(" "); - Testing
        for (int i = 0; i < Words.Count; i++)
        {
            Console.Write(" ");
            Words[i].DisplayWord();
        }
        //Console.Write(".");
    }
    
    public void HideRandomWord(){
        /*
        Method: hides a random word in the scripture

        Variables: accepts no variables

        Returns: none
        */
        
        
        RandI = PickRandom(UsedRand);
        if (RandI > 0){
            
            Words[RandI-1].Hide();
        }        
        //Console.WriteLine($"{RandI} {Words[RandI]}"); - for testing
        //if (RandI < Words.Count()){
        //    Words[RandI+1].Hide();
        //    UsedRand.Add(RandI+1);
        //}
        Words[RandI].Hide();
        UsedRand.Add(RandI);
        }

    public string IsCompletelyHidden(){
        /*
        Method: checks if the scripture if completely hidden and exits program

        Variables: accepts no variables

        Returns: ifExit
        */
        int count = Words.Count();
        if (count <= UsedRand.Count()){
            foreach (Word item in Words)
            {
                item.Hide();
            }
            string ifExit = "exit";
            return ifExit;
        }
        else{
            string ifExit = "next";
            return ifExit;
        }
    }

    public void LoadScripture(){
        /*
        Method: loads a file of scriptures

        Variables: 

        Returns: 
        */
    }

    private void ConvertToList(string scripture){
        string[] text = scripture.Split(' ');
        foreach (string word in text){
            Word = new Word();
            Word.SetWord(word);
            //Console.WriteLine($"{word}"); - For troubleshooting
            //Word.DisplayWord(); - For troubleshooting
            Words.Add(Word);
            
        }
    }

    private int PickRandom(List<int> randomList){
        //int rand;
        Random Rand = new Random();
        
        do {
            RandI = Rand.Next(0, Words.Count); 
        } while (UsedRand.Contains(RandI));
        UsedRand.Add(RandI);
        UsedRand.Add(RandI);
        return RandI;
        //string randString = Console.ReadLine();
        //int randI = int.Parse(randString);
        //return randI;
        
    }
}