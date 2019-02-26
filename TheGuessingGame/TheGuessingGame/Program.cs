using System;
using System.Dynamic;


namespace TheGuessingGame
{
    class Program
    {
        private static GuessingGame game;

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
                game = new GuessingGame();

                string inputLine = "";
                while (!game.IsOver)
                {
                    // UI ELEMENT - Let's introduce this program!
                    DisplayMainUI();

                    // USER INPUT
                    inputLine = Console.ReadLine();

                    // Convert our answer to an int after checking that it can be converted 
                    bool parseAttempt = int.TryParse(inputLine, out int guess);
                    if (!parseAttempt)
                    {
                        Console.WriteLine("Incorrect input.  Please input a number between{0} and {1}", game.Lowerbound, game.Upperbound);
                    }
                    

                    // Decide if our user has won
                    if (game.Guess(guess))
                    {
                        Console.WriteLine("Congratulations! You won!");
                    }
                    else
                    {
                        Console.WriteLine("Nope! Press any key to guess again!");
                    }
                    Console.ReadKey();
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

        static void DisplayMainUI()
        {
            Console.Clear();
            Console.WriteLine("==========================================================================");
            Console.WriteLine("=");
            Console.WriteLine("=   This is a guessing game. Please guess a number from 1 to 10!");
            //Console.WriteLine("(Answer is actually {0})", game.Answer);
            Console.WriteLine("=   You have guessed {0} times so far.", game.NumberOfGuesses);
            Console.WriteLine("=   Your Previous Guesses were :: {0}", game.PreviousGuesses);
            Console.WriteLine("=");
            Console.WriteLine("==========================================================================");
        }
    }
}
