using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Program
    {
        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {   
            // Create the model
            // Initialize the player list with two players using collection
            // initialization syntax
            List<Player> playerList = new List<Player>() {
            new Player("Best player ever", 100),
            new Player("An even better player", 500)
            };
            // Create a new instance of the player listing program
            Controller controller = new Controller(playerList);
            // Create a new instance of the View class
            SillyView view= new SillyView(controller, playerList);
            // Start the program instance
            controller.Start(view);
        }

    }
}