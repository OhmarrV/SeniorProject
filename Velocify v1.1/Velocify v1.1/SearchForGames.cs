using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class SearchForGames : Form
    {
        private List<GameData> allGames;

        public SearchForGames()
        {
            InitializeComponent();
            LoadAllGames();
        }

        private async void LoadAllGames()
        {
            // Load all games from your API or database and store them in the allGames list
            allGames = await APIFile.GetAllGamesAsync(); // Implement this method to get all games
            UpdateGameListBox(""); // Populate list box with all games initially
        }

        private void UpdateGameListBox(string searchQuery)
        {
            gamesListBox.Items.Clear(); // Clear the existing items

            // Filter the games based on the search query and update the list box
            foreach (var game in allGames)
            {
                if (game.name.ToLower().Contains(searchQuery))
                {
                    gamesListBox.Items.Add($"Name: {game.name}, ID: {game.id}, Cover URL: {game.coverUrl}");
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string gameName = textBox1.Text;

            if (!string.IsNullOrEmpty(gameName))
            {
                // Call the API to search for the game
                var gameData = await APIFile.GetGameDataAsync(gameName);

                if (gameData.id != 0)
                {
                    // Display the game data (game name, id, cover URL) in the ListBox
                    gamesListBox.Items.Clear(); // Clear previous results
                    gamesListBox.Items.Add($"Name: {gameData.name}, ID: {gameData.id}, Cover URL: {gameData.coverUrl}");
                }
                else
                {
                    MessageBox.Show("No game found or an error occurred.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a game name.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.ToLower();

            // Ensure you only call the API if there is input
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Split the search query to separate name and genre if necessary
                string[] searchTerms = searchQuery.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string nameQuery = searchTerms.Length > 0 ? searchTerms[0] : "";
                string genreQuery = searchTerms.Length > 1 ? searchTerms[1] : ""; 

                // Call the API with the name and genre
                var gamesByNameAndGenre = await APIFile.GetGamesByNameAndGenreAsync(nameQuery, genreQuery);

                // Clear the list box before adding new items
                gamesListBox.Items.Clear();

                if (gamesByNameAndGenre != null && gamesByNameAndGenre.Count > 0)
                {
                    foreach (var game in gamesByNameAndGenre)
                    {
                        gamesListBox.Items.Add($"Name: {game.name}, Genre: {game.genre}, ID: {game.id}");
                    }
                }
                else
                {
                    gamesListBox.Items.Add("No games found.");
                }
            }
            else
            {
                gamesListBox.Items.Clear();
            }
        }
    }
}

