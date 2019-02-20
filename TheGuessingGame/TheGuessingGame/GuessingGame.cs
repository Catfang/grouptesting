using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGuessingGame
{
    public class GuessingGame
    {
        public void Play()
        {
            // DEFINE WINNING GAME STATE
            string inputLine = "";
            bool stillPlaying = true;

            while (stillPlaying)
            {

                Console.Clear();
                // Made the win state Random! 
                // Create a new random instance.
                Random random = new Random();
                // create an integer set it equal to a new random number with min and max bounds.  the min is inclusive, and the max is exclusive.
                int answer = random.Next(1, 11);


                // UI ELEMENT - Let's introduce this program!
                Console.WriteLine("This is a guessing game. Please guess a number from 1 to 10!");

                // USER INPUT
                inputLine = Console.ReadLine();

                // Convert our answer to a string
                int guess = int.Parse(inputLine);

                // Decide if our user has won
                if (guess == answer) { Console.WriteLine("Congratulations! You won!"); }
                else { Console.WriteLine("Ha ha ha! You loser!"); }

                // Find out if player wants to play again after being called a loser
                Console.WriteLine("Would you like to play again?");
                inputLine = Console.ReadLine();
                if (inputLine == "n" || inputLine == "N") { stillPlaying = false; }

            }
        }
    }
}
