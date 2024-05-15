using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class SillyView : IView
    {
        private readonly Controller controller;
        private readonly List<Player> playerList;
        public SillyView(Controller controller, List<Player> playerList)
        {
            this.controller = controller;
            this.playerList = playerList;
        }
    }
}