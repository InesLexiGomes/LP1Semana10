using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private int targetNumber;
        private int guess;
        private bool guessedCorrectly;
        private int attempts;
        public Controller(int targetNumber, bool guessedCorrectly, int attempts)
        {
            this.targetNumber = targetNumber;
            this.guessedCorrectly = guessedCorrectly;
            this.attempts = attempts;
        }
        public void Start(IView view)
        {
            view.Instructions();

            // Game loop
            while (!guessedCorrectly)
            {
                guess = view.Guess();
                attempts++;

                if (guess == targetNumber)
                {
                    guessedCorrectly = view.GuessCorrectly(attempts);
                }
                else if (guess < targetNumber)
                {
                    view.TooLow();
                }
                else
                {
                    view.TooHigh();
                }
            }

            view.Thank();
        }
    }
}