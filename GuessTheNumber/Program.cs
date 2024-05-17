using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Controller controller = new Controller();
            View view = new View();

            controller.Start(view);
            
        }
    }
}