using System;

class Program
{
    static void Main(string[] args)
    {
        string exit = "noquit";

        // Create a list of scriptures
        List<Scripture> scriptures = new List<Scripture>();

        // Add scripture ref and verse to list
        Reference ref1 = new Reference("Philippians", 4, 13);
        scriptures.Add(new Scripture(ref1, "I can do all things through Christ which strengtheneth me."));
        Reference ref2 = new Reference("1 Nephi", 3, 7);
        scriptures.Add(new Scripture(ref2, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        Reference ref3 = new Reference("1 Nephi", 16, 16);
        scriptures.Add(new Scripture(ref3, " And we did follow the directions of the ball, which led us in the more fertile parts of the wilderness."));
        Reference ref4 = new Reference("Doctrine and Covenants", 18, 10, 11);
        scriptures.Add(new Scripture(ref4, "And if it so be that you should labor all your days in crying repentance unto this people, and bring, save it be one soul unto me, how great shall be your joy with him in the kingdom of my Father! And now, if your joy will be great with one soul that you have brought unto me into the kingdom of my Father, how great will be your joy if you should bring many souls unto me!"));

        Random random = new Random();
        // Get a random index within the range of the scriptures list
        int randomIndex = random.Next(0, scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        while (exit != "quit"){
            // Clear Console
            Console.Clear();
            //Call check within scripture class if it is completely hidden
            //Store variable from method to determine what to do next
            string next = selectedScripture.IsCompletelyHidden();
            // Call Display Scripture
            selectedScripture.DisplayScripture();
            
            //Write blank line nd instructions
            Console.WriteLine("");
            Console.Write("Press enter or type quit to exit: ");
            
            // Read user inpuit
            exit = Console.ReadLine();

            
            
            //Id not completely hidden, hide next word
            if (next == "next"){
                selectedScripture.HideRandomWords();
            }
            //Else quit program
            else{
                Console.Clear();
                selectedScripture.DisplayScripture();
                Console.WriteLine("\nThe scripture is completely hidden.");
                exit = "quit";
            }
            
        }
    }
}
