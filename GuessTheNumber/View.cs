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
            Console.WriteLine("Congratulations! You guessed correctly!");
            Console.WriteLine($"Number of attempts: {attempts}");
            return true;
        }
        public void Thank()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

        public int Guess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void TooHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }
        public void TooLow()
        {
            Console.WriteLine("Too low! Try again.");
        }
     }
}