using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Controller
    {
        private readonly List<Player> list;
        // Comparer for comparing player by name (alphabetical order)
        private readonly IComparer<Player> compareByName;

        // Comparer for comparing player by name (reverse alphabetical order)
        private readonly IComparer<Player> compareByNameReverse;

        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        public Controller(List<Player> list)
        {
            this.list = list;
            // Initialize player comparers
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);
        }

        /// <summary>
        /// Start the player listing program instance
        /// </summary>
        public void Start(IView view)
        {
            // We keep the user's option here
            int option;

            // Main program loop
            do
            {
                // Show menu and get user option
                option = view.ShowMenu();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case 1:
                        // Insert player
                        list.Add(view.InsertPlayer());
                        break;
                    case 2:
                        view.ListPlayers(list);
                        break;
                    case 3:
                        ListPlayersWithScoreGreaterThan(view);
                        break;
                    case 4:
                        SortPlayerList(view);
                        break;
                    case 0:
                        view.EndMessage();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }

                view.AfterMenu();

                // Loop keeps going until players choses to quit (option 4)
            } while (option != 0);
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan(IView view)
        {
            // Minimum score user should have in order to be shown
            int minScore;
            // Enumerable of players with score higher than the minimum score
            IEnumerable<Player> playersWithScoreGreaterThan;

            minScore = view.AskForMinimumScore();

            // Get players with score higher than the user-specified value
            playersWithScoreGreaterThan =
                GetPlayersWithScoreGreaterThan(minScore);

            // List all players with score higher than the user-specified value
            view.ListPlayers(playersWithScoreGreaterThan);
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            // Cycle all players in the original player list
            foreach (Player p in list)
            {
                // If the current player has a score higher than the
                // given value....
                if (p.Score > minScore)
                {
                    // ...return him as a member of the player enumerable
                    yield return p;
                }
            }
        }

        /// <summary>
        ///  Sort player list by the order specified by the user.
        /// </summary>
        private void SortPlayerList(IView view)
        {
            PlayerOrder playerOrder = view.AskForPlayerOrder();

            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    list.Sort();
                    break;
                case PlayerOrder.ByName:
                    list.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    list.Sort(compareByNameReverse);
                    break;
                default:
                    view.InvalidOption();
                    break;
            }
        }
    }
}
