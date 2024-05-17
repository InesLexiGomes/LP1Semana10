using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Model model = new Model();

            Controller controller = new Controller(model);

            View view = new View();

            controller.Start(view);
            
        }
    }
}