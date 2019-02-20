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

            //Create GuessingGame instance
            GuessingGame game = new GuessingGame();

            game.Play();

            // Added exit to make it an instant exit instead of a multiple key press.
            Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
