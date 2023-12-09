using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing Activity", 44);
        ListingActivity listing = new ListingActivity("Listing Activity", 30);
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", 45);

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