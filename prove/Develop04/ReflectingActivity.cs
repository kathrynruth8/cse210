public class ReflectingActivity : Activity
{
    private List<string> ReflectingPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", 
        "Reflect on a challenging decision you made",
        "Describe a time when you received unexpected kindness from someone.",
        "Think about a time when you learned something valuable from a mistake"
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
        var random = new Random();
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?", 
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            // Add more questions as needed
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(ActivityDuration);

        while (DateTime.Now < endTime)
        {
            int index = random.Next(questions.Length);
            string question = questions[index];

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
