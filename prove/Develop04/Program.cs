using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing Activity", 44, "This activity will help you relax by guiding you through slow breathing exercises.");
        ListingActivity listing = new ListingActivity("Listing Activity", 30, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", 45, "This activity will help you reflect on times in your life when you have shown strength and resilience.");

        Console.WriteLine("Welcome to the Mindfulness Program!");

        int choice;
        do
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start reflecting activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    breathing.StartBreathing();
                    break;

                case 2:
                    listing.StartListing();
                    break;

                case 3:
                    reflecting.StartReflecting();
                    reflecting.DisplayUserResponses();
                    break;

                case 4:
                    Console.WriteLine("Exiting the Mindfulness Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid number.");
                    break;
            }
        } while (choice != 4);
    }
}