using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Controller controller = new Controller(model);
            View view = new View();

            controller.Start(view);
            
        }
    }
}