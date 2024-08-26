using GameListApp;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the GameListManager
        GameListManager gameListManager = new GameListManager();

        // Initialize the games list with some titles
        gameListManager.InitializeGamesList();

        // Array of additional game titles
        string[] otherGames = { "Assassin's Creed", "Cyberpunk 2077" };

        // Display all games in the list
        gameListManager.DisplayGames();

        // Print the number of items in the list
        gameListManager.DisplayGameCount();

        // Add a range of games from the array
        gameListManager.AddGamesFromArray(otherGames);

        // Print the updated number of items in the list
        gameListManager.DisplayGameCount();

        // Check if "Halo" is in the list, and handle accordingly
        gameListManager.CheckAndAddHalo();

        // Remove game at index 6 if it exists
        int indexToRemove = 6;
        gameListManager.RemoveGameAtIndex(indexToRemove);

        // Display all games in the list
        Console.WriteLine("All games in the list:");
        gameListManager.DisplayGames();

        // Sort the games list
        gameListManager.SortGames();

        // Display the sorted games list
        Console.WriteLine("Sorted Games List:");
        gameListManager.DisplayGames();

        // Copy games list to a new array
        gameListManager.CopyToNewList(out string[] newList);

        // Clear the original games list
        gameListManager.ClearGames();

        // Display each game in the new array
        Console.WriteLine("Games in the new list:");
        foreach (var game in newList)
        {
            Console.WriteLine(game);
        }
    }
}