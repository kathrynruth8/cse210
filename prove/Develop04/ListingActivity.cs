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
        "Who are some of your personal heroes?"
    };
    private List<string> UserList = new List<string>{};
    
// Constructors
    public ListingActivity(string activityName, int activityDuration, string activityDescription)
        : base(activityName, activityDuration, activityDescription)
    {
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
        int promptDuration = 5;
        
        var random = new Random();
        int index = random.Next(ListingPrompts.Count);
        string question = ListingPrompts[index];
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        Pause(8);

        Console.WriteLine("How many items can you list?");
        int itemsToEnter = ActivityDuration;

        for (int i = 0; i < itemsToEnter; i++)
        {
            Console.Write("Enter item " + (i + 1) + ": ");
            string userInput = Console.ReadLine();
            UserList.Add(userInput);
        }

        Console.WriteLine("You listed " + UserList.Count + " items.");
        FinishActivity();
    }
}

