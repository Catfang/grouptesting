using System;


namespace TheGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // This *very* buggy and brittle code is the start of our first
            // group-driven game development.

            // DEFINE WINNING GAME STATE
            // Made the win state Random! 
            // Create a new random instance.
            Random random = new Random();
            // create an integer set it equal to a new random number with min and max bounds.  the min is inclusive, and the max is exclusive.
            int answer = random.Next(1,11);
            

            // UI ELEMENT - Let's introduce this program!
            Console.WriteLine("This is a guessing game. Please guess a number from 1 to 10!");

            // USER INPUT
            string inputLine = Console.ReadLine();

            // Convert our answer to a string
            int guess = int.Parse(inputLine);

            // Decide if our user has won
            if (guess == answer) { Console.WriteLine("Congratulations! You won!"); }
            else { Console.WriteLine("Ha ha ha! You loser!"); }

            Console.ReadKey();
        }
    }
}
