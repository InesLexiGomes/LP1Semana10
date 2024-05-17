using System;

namespace GuessTheNumber
{
    public class Model
    {
        private int targetNumber;
        private int guess;
        private bool guessedCorrectly;
        private int attempts;
        public Model()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            targetNumber = random.Next(1, 101);
            guessedCorrectly = false;
            attempts = 0;
        }
    }
}