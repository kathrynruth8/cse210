public class JournalPrompt
{
    private static string[] _prompt = {
        "Write about something positive that happened to you recently that made you feel more fortunate. ",
        "Name five things that make you smile. Reflect on how these affect your mood. ",
        "Write down five objects found in nature you're grateful for. ",
        "What are some of your favorite things about your town, city or state?",
        "Write a paragraph about what you admire about your favorite person in the world.",
        " What top three things/people make your home feel special?",
        "Which three struggles have you overcome throughout your life and how did these make you a better person?",
        "List three qualities you admire about yourself.",
        "Make a list of what makes your closest friends special. ",
        "What are 10 items you own that make your life easier (technology, appliances, etc.)?",
        "What's your favorite smell in the whole world? Write down how it stirs your senses and provokes your emotions.",
        "Pick your favorite teacher or professor from your past or present and write about what makes him or her special.", 
        "Pick a holiday you enjoy and write two paragraphs about why you feel this way. ",
        "Write down three reasons why a particular object in your home brings you joy.",
        "Put down three paragraphs about a family member and why you're thankful for them.",
        "What's your favorite color and what about it boosts your positivity?",
        "List nine things you can do to love yourself more and try incorporating these into your everyday life.",
        "How can doing good for others make you happier than doing things for yourself?",
        "What did your parents teach you growing up that made you a better person?",
        "What did your parents teach you growing up that made you a better person?",
        "Make a list of things that irritate you. Then write down ways to see them from a different perspective. Can you laugh at some of these or make them easier to handle?",
        "Write down one highlight of your day and why it's positive for you.",
        "In your opinion, what's something that makes a person genuinely beautiful?",
        "Name one thing you like about your appearance and write a paragraph about it. ",
        "What or who makes life more meaningful to you?",
        "Which talent do you appreciate the most about someone you admire and why?",
        "What or who are you the most grateful for?",
        "What's one memory or moment you'll always cherish?",
        "Name one thing/person that makes your life more exciting?",
        "What's something positive (self-love affirmations or positive self-talk) you can say to yourself every day?",
        "What gift did you receive that mattered to you the most and why?",
        "Look outside your window and list 10 things you're thankful for. ",
        "List one way your best friend has made you smile.",
        "Write down one thing about each family member you’re grateful for." 
    };

    public List<string> _journalPrompt = new List<string>(_prompt);
    

    public JournalPrompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];

        return journalPrompt;

    }

}