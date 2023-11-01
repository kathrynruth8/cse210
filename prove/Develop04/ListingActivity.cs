public class ListingActivity : Activity{
// Attributes
    private string _listingIntro = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _userList = new List<string>{};
// Constructors
    public ListingActivity(string activityName, int activityDuration)
        :base(activityName, activityDuration)
        {}
    
// Methods
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_listingPrompts.Count);
        return _listingPrompts[index];
    }

    public void ReturnRandomPrompt(int seconds)
    {
        Console.WriteLine();
        var question = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        CountDown(8);
        Timer(seconds);
    }

}
// **************
// 1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.

// 2. The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
// 3. After the starting message, select a random prompt to show the user such as:
        // - Who are people that you appreciate?
        // - What are personal strengths of yours?
        // - Who are people that you have helped this week?
        // - When have you felt the Holy Ghost this month?
        // - Who are some of your personal heroes?

// 4. After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.

// 5. The user lists as many items as they can until they they reach the duration specified by the user at the beginning.

// 6. The activity them displays back the number of items that were entered.

// 7. The activity should conclude with the standard finishing message for all activities.
