using System;
using System.Collections.Generic;

namespace GameListApp
{
    // This class handles the operations on the games list.
    class GameListManager
    {
        public List<string> Games { get; private set; }

        public GameListManager()
        {
            Games = new List<string>();
        }

        public void InitializeGamesList()
        {
            Games = new List<string> { "The Witcher 3", "God of War", "Red Dead Redemption 2" };
        }

        public void AddGamesFromArray(string[] otherGames)
        {
            Games.AddRange(otherGames);
        }

        public void DisplayGames()
        {
            Console.WriteLine("Games in the list:");
            foreach (var game in Games)
            {
                Console.WriteLine(game);
            }
        }

        public void DisplayGameCount()
        {
            Console.WriteLine($"Number of games in the list: {Games.Count}");
        }

        public void CheckAndAddHalo()
        {
            if (Games.Contains("Halo"))
            {
                Console.WriteLine("MASTER CHIEF is in the house!");
            }
            else
            {
                Games.Add("Halo");
                Console.WriteLine("Halo added to the list.");
            }
        }

        public void RemoveGameAtIndex(int index)
        {
            if (index < Games.Count)
            {
                Games.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Game not found!");
            }
        }

        public void SortGames()
        {
            Games.Sort();
        }

        public void CopyToNewList(out string[] newList)
        {
            newList = new string[Games.Count];
            Games.CopyTo(newList);
        }

        public void ClearGames()
        {
            Games.Clear();
        }
    }
   
}