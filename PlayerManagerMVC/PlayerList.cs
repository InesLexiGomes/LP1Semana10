using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class PlayerList
    {        

        // Initialize the player list with two players using collection
        // initialization syntax
        public List<Player> List {get;} = new List<Player>() {
        new Player("Best player ever", 100),
        new Player("An even better player", 500)
        };
    }
}