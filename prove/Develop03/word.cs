public class Word{
    //Tracks individual words and if they are hidden

    // Declare variables
    
    private Boolean IsHidden = false;
    private string MyWord;

    // Constructor
    public Word(string word){
        MyWord = word;
    }
    public Word(){}
    
    // Methods
        public void SetWord(string word){
            MyWord = word;
        }

        public void DisplayWord(){
            Console.Write(MyWord);
        }

        public void Hide(){
            if(IsHidden == false){
                char[] chars = MyWord.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                    {
                    //Console.Write(chars[i]); - for testing
                    chars[i] = '_';
                    //Console.WriteLine(chars[i]); - for testing
                    }
                string word = new string(chars);
                //Console.WriteLine(word); - for testing
                IsHidden = true;
                MyWord = word;
            }
            
        }
        
}