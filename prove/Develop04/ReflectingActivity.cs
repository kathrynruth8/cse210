public class ReflectingActivity : Activity
{
    private List<string> ReflectingPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        // Add more prompts as needed
    };
    private string ReflectingIntro = "This activity will help you reflect on the good things in your life by having you write a response to a given prompt.";
    private List<string> UserResponses = new List<string>();

    public ReflectingActivity(string activityName, int activityDuration)
        : base(activityName, activityDuration, "")
    {
        ActivityIntro = ReflectingIntro;
    }

    public void StartReflecting()
    {
        StartActivity();
        var random = new Random();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(ActivityDuration);

        while (DateTime.Now < endTime)
        {
            int index = random.Next(ReflectingPrompts.Count);
            string prompt = ReflectingPrompts[index];

            Console.WriteLine("\nReflect on the following prompt:");
            Console.WriteLine($"\n--- {prompt} ---");
            Pause(5);

            AskReflectionQuestions();
        }

        Console.WriteLine("Time's up!");
        FinishActivity();

    }

    private void AskReflectionQuestions()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            // Add more questions as needed
        };

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            // Display spinner animation or some kind of pause
            Pause(3);

            string userResponse = Console.ReadLine();
            UserResponses.Add(userResponse);
        }
    }

    public void DisplayUserResponses()
    {
        Console.WriteLine("Your responses for Reflecting Activity:");
        foreach (string response in UserResponses)
        {
            Console.WriteLine(response);
        }
    }
}
