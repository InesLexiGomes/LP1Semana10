using System;

namespace GuessTheNumber
{
    public class Controller
    {
        public void Start(IView view)
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

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