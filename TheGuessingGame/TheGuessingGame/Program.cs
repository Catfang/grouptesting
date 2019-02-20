using System;
using System.Dynamic;


namespace TheGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // This *very* buggy and brittle code is the start of our first
            // group-driven game development.


            // NOTE!!
            // Because this is a console app, this class and method are now the "UI" for our game.
            // In the future, we can port our game more easily if it's not tied to UI elements.

            bool stillPlaying = true;

            while (stillPlaying)
            {

                //Create GuessingGame instance
                GuessingGame game = new GuessingGame();

                // UI ELEMENT - Let's introduce this program!
                Console.WriteLine("This is a guessing game. Please guess a number from 1 to 10!");
                Console.WriteLine("(Answer is actually {0})", game.Answer);

                string inputLine = "";
                while (!game.IsOver)
                {
                    // USER INPUT
                    inputLine = Console.ReadLine();

                    // Convert our answer to a string
                    int guess = int.Parse(inputLine);

                    // Decide if our user has won
                    if (game.Guess(guess))
                    {
                        Console.WriteLine("Congratulations! You won!");
                    }
                    else
                    {
                        Console.WriteLine("Nope! Guess again!");
                    }
                }

                // Find out if player wants to play again
                Console.WriteLine("Would you like to play again?");
                inputLine = Console.ReadLine();
                if (inputLine == "n" || inputLine == "N") { stillPlaying = false; }
            }



            // Added exit to make it an instant exit instead of a multiple key press.
            Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
