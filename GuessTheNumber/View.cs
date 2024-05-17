using System;

namespace GuessTheNumber
{
    class View : IView
     {
        /// <summary>
        /// Prints the instructions for the game
        /// </summary>
        public void Instructions()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool GuessCorrectly(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.WriteLine($"Number of attempts: {attempts}");
            return true;
        }
        public void Thank()
        {

        }
     }
}