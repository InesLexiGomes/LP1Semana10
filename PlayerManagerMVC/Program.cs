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
        {   // Create the model
            PlayerList list = new PlayerList();
            // Create a new instance of the player listing program
            Controller controller = new Controller();
            // Start the program instance
            controller.Start();
        }

    }
}