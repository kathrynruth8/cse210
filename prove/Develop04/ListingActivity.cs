public class ListingActivity : Activity
{
// Attributes
    private string ListingIntro = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> ListingPrompts = new List<string>
    {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Name things that always make you smile, no matter what.",
        "Describe qualities in yourself that you admire and aspire to enhance.",
        "Who are people that inspire you to be a better person.",
        "What are the skills or talents you have that you're proud of developing.",
        "What are some small acts of kindness you've witnessed or participated in recently."
    };
    private List<string> UserList = new List<string>{};
    
// Constructors
    public ListingActivity(string activityName, int activityDuration)
        : base(activityName, activityDuration, "")
    {
        ActivityIntro = ListingIntro;
    }
    
// Methods
public void DisplayIntroduction()
    {
        Console.WriteLine(ListingIntro);
    }
public void StartListing()
    {
        StartActivity();
        int totalDuration = ActivityDuration;

        var random = new Random();
        int index = random.Next(ListingPrompts.Count);
        string question = ListingPrompts[index];
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        Pause(8);

        Console.WriteLine("You have " + totalDuration + " seconds to list items.");
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < totalDuration)
        {
            Console.Write("Enter an item: ");
            string userInput = Console.ReadLine();
            UserList.Add(userInput);
        }

        Console.WriteLine("You listed " + UserList.Count + " items.");
        UserList.Clear();
        FinishActivity();
    }   
}

