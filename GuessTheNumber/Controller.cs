using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private int guess;
        private Model model;
        public Controller(Model model)
        {
            this.model = model;
        }
        public void Start(IView view)
        {
            view.Instructions();

            // Game loop
            while (!model.GuessedCorrectly)
            {
                guess = view.Guess();
                model.Attempts++;

                if (guess == model.TargetNumber)
                {
                    model.GuessedCorrectly=view.GuessCorrectly(model.Attempts);
                }
                else if (guess < model.TargetNumber)
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