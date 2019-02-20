using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGuessingGame
{
    public class GuessingGame
    {
        // these are both inclusive
        public int Lowerbound { get; private set; }
        public int Upperbound { get; private set; }

        public int Answer { get; private set; }
        public int NumberOfGuesses { get; private set; }

        public bool IsOver { get; private set; }

        Random RNG = new Random();


        // Constructor - let's create the game!
        public GuessingGame(int lowerbound = 1, int upperbound = 10)
        {
            Lowerbound = lowerbound;
            Upperbound = upperbound;
            NumberOfGuesses = 0;
            Answer = RNG.Next(lowerbound, upperbound + 1);
            IsOver = false;
        }

        public bool Guess(int guess)
        {
            NumberOfGuesses++;
            if (guess == Answer)
                IsOver = true;
            return IsOver;
        }

    }
}
