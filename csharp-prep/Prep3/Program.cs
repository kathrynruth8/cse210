using System;

class Program
{
    static void Main(string[] args)
    {
        // // Start by asking the user for the magic number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        // Ask the user for a guess.
        // Console.Write("What is your guess? ");
        // int guess = int.Parse(Console.ReadLine());
    
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            // Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
        }
}