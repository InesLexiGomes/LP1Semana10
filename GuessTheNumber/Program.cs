using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);

            int attempts = 0;
            bool guessedCorrectly = false;

            Controller controller = new Controller(targetNumber, guessedCorrectly, attempts);
            View view = new View();

            controller.Start(view);
            
        }
    }
}